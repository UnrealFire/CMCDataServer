using System;
using System.Linq;
namespace CMCDataServer
{
    public static class DBTools
    {

        public static void InitializeDB (Models.CMCDataContext context)
        {
            if (!context.Currencies.Any())
            {
                context.Currencies.AddRange(
                    //todo update table from CMCData
                );
                context.SaveChanges();
            }
        }
    }
}
