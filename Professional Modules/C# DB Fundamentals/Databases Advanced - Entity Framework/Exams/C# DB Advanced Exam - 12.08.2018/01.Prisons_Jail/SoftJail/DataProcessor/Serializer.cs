using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;
using SoftJail.DataProcessor.ExportDto;
using SoftJail.DataProcessor.ImportDto;

namespace SoftJail.DataProcessor
{

    using Data;
    using System;

    public class Serializer
    {
        public static string ExportPrisonersByCells(SoftJailDbContext context, int[] ids)
        {
            var exportPrisoners = context
                .Prisoners
                .Where(id => ids.Contains(id.Id))
                .Select(pd => new
                {
                    Id = pd.Id,
                    Name = pd.FullName,
                    CellNumber = pd.Cell.CellNumber,
                    Officers = pd.PrisonerOfficers.Select(po => new
                    {
                        OfficerName = po.Officer.FullName,
                        Department = po.Officer.Department.Name
                    })
                        .OrderBy(o => o.OfficerName)
                        .ToArray(),
                    TotalOfficerSalary = pd.PrisonerOfficers.Select(x => x.Officer.Salary).Sum()
                })
                .OrderBy(o => o.Name)
                .ThenBy(t=> t.Id)
                .ToArray();

            var json = JsonConvert.SerializeObject(exportPrisoners, Newtonsoft.Json.Formatting.Indented);
            return json;
            /*Use the method provided in the project skeleton, which receives a string of comma-separated prisoner names.
             Export the prisoners: for each prisoner, export its id, name, incarcerationDate in the format “yyyy-MM-dd” and their encrypted mails. 
             The encrypted algorithm you have to use is just to take each prisoner mail description and reverse it. Sort the prisoners by their name (ascending), 
             then by their id (ascending).*/
        }

        public static string ExportPrisonersInbox(SoftJailDbContext context, string prisonersNames)
        {
            var names = prisonersNames.Split(",");
            var exportXmlPrisoners = context
                .Prisoners
                .Where(n => names.Contains(n.FullName))
                .Select(x => new ExportPrisonerDto
                {
                    Id = x.Id,
                    Name = x.FullName,
                    IncarcerationDate = x.IncarcerationDate.ToString("yyyy-MM-dd"),
                    EncryptedMessages = x.Mails.Select(m => new MessageDto
                    {
                            Description = ReverseStr(m.Description)
                        })
                        .ToArray()
                })
                .OrderBy(n => n.Name)
                .ThenBy(i => i.Id)
                .ToArray();
            var serializer = new XmlSerializer(typeof(ExportPrisonerDto[]), new XmlRootAttribute("Prisoners"));

            var sb = new StringBuilder();
            var namespaces = new XmlSerializerNamespaces(new[] { new XmlQualifiedName("", "") });
            serializer.Serialize(new StringWriter(sb), exportXmlPrisoners, namespaces);

            var result = sb.ToString();
            return result;

        }

        private static string ReverseStr(string input)
        {
            var sb = new StringBuilder();

            for (int i = input.Length-1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }
            return sb.ToString().TrimEnd();
        }
    }

    //<Id>3</Id>
    //<Name>Binni Cornhill</Name>
    //<IncarcerationDate>1967-04-29</IncarcerationDate>
    //<EncryptedMessages>
    //<Message>
    //<Description>!?sdnasuoht evif-ytnewt rof deksa uoy ro orez artxe na ereht sI</Description>
    //</Message>
    //</EncryptedMessages>

}