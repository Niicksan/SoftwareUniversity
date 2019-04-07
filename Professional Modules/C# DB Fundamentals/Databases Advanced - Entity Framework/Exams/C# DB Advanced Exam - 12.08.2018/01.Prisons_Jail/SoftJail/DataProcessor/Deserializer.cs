using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Newtonsoft.Json;
using SoftJail.Data.Models;
using SoftJail.Data.Models.Enums;
using SoftJail.DataProcessor.ImportDto;

namespace SoftJail.DataProcessor
{

    using Data;
    using System;

    public class Deserializer
    {
        public static string ImportDepartmentsCells(SoftJailDbContext context, string jsonString)
        {
            var sb = new StringBuilder();
            var deserializeDepartments = JsonConvert.DeserializeObject<Department[]>(jsonString);
            var validDepartment = new List<Department>();

            foreach (var dto in deserializeDepartments)
            {
                var validateData = IsValid(dto) && dto.Cells.All(IsValid);
                if (validateData)
                {
                    validDepartment.Add(dto);
                    sb.AppendLine($"Imported {dto.Name} with {dto.Cells.Count} cells");
                }
                else
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }
             
            }
            context.Departments.AddRange(validDepartment);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportPrisonersMails(SoftJailDbContext context, string jsonString)
        {
            var sb = new StringBuilder();
            var deserializePrisonersMailsDtos = JsonConvert.DeserializeObject<ImportPrisonersMailsDto[]>(jsonString);
            var validPrisoners = new List<Prisoner>();

            foreach (var departmentDto in deserializePrisonersMailsDtos)
            {
                if (!IsValid(departmentDto) || !departmentDto.Mails.All(IsValid))
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                var mails = departmentDto.Mails.Select(x => new Mail(x.Description, x.Address, x.Sender)).ToArray();

                var prisoner = new Prisoner
                {
                    FullName = departmentDto.FullName,
                    Nickname = departmentDto.Nickname,
                    Age = departmentDto.Age,
                    IncarcerationDate = DateTime.ParseExact(departmentDto.IncarcerationDate, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    ReleaseDate = departmentDto.ReleaseDate==null? new DateTime(): DateTime.ParseExact(departmentDto.ReleaseDate, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Bail = departmentDto.Bail,
                    CellId = departmentDto.CellId,
                    Mails = mails

                };

                validPrisoners.Add(prisoner);
                sb.AppendLine($"Imported {prisoner.FullName} {prisoner.Age} years old");
            }
            context.Prisoners.AddRange(validPrisoners);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
            throw new NotImplementedException();
        }

        public static string ImportOfficersPrisoners(SoftJailDbContext context, string xmlString)
        {
            var sb = new StringBuilder();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportOfficersPrisonersDto[]), new XmlRootAttribute("Officers"));

            var officersPrisonersDtosDtos = (ImportOfficersPrisonersDto[])xmlSerializer.Deserialize(new StringReader(xmlString));

            var officers = new List<Officer>();
            var officersPrisoners = new List<OfficerPrisoner>();


            foreach (var dto in officersPrisonersDtosDtos)
            {
                var weaponTest = Enum.TryParse<Weapon>(dto.Weapon,true, out Weapon weapon);
                var positionTest = Enum.TryParse<Position>(dto.Position, true, out Position position);
                
                if (!IsValid(dto) || !positionTest || !weaponTest)
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }
                else
                {
                    var tempOfficers = new Officer
                    {
                        FullName = dto.FullName,
                        Salary = dto.Money,
                        Position = position,
                        Weapon = weapon,
                        DepartmentId = dto.DepartmentId,
                        OfficerPrisoners = dto.Prisoners.Select(p => new OfficerPrisoner
                        {
                            PrisonerId = p.Id
                        }).ToArray()
                    };

                    officers.Add(tempOfficers);
                    sb.AppendLine($"Imported {tempOfficers.FullName} ({tempOfficers.OfficerPrisoners.Count} prisoners)");
                }

            }
            context.Officers.AddRange(officers);
            context.SaveChanges();
           
            return sb.ToString().TrimEnd();
        }
        public static bool IsValid(object obj)
        {
            var validationContext = new ValidationContext(obj);
            var result = new List<ValidationResult>();

            return Validator.TryValidateObject(obj, validationContext, result, true);
        }
    }
}