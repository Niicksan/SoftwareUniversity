using System.Text;

namespace SoftJail.DataProcessor
{

    using Data;
    using System;

    public class Bonus
    {
        public static string ReleasePrisoner(SoftJailDbContext context, int prisonerId)
        {
            var sb = new StringBuilder();

            var prisonerThatWillBeRelease = context.Prisoners.Find(prisonerId);

            if (prisonerThatWillBeRelease.ReleaseDate == null)
            {
                return ($"Prisoner {prisonerThatWillBeRelease.FullName} is sentenced to life");

            }
            prisonerThatWillBeRelease.ReleaseDate = DateTime.Now;
            prisonerThatWillBeRelease.CellId = null;

            context.Prisoners.Update(prisonerThatWillBeRelease);
            context.SaveChanges();

            return ($"Prisoner {prisonerThatWillBeRelease.FullName} released");
        }
    }
}
