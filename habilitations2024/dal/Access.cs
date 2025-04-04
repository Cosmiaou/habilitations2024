using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using habilitations2024.bddmanager;

namespace habilitations2024.dal
{
    public class Access
    {

        private static readonly string connectionString = "Server=localhost;Database=habilitations;User Id=habilitations;Password=motdepasseuser;";
        private static Access instance = null;
        private static readonly object locker = new object();

        public BddManager Manager { get; }

        private Access()
        {
            try
            {
                this.Manager = BddManager.getInstance(connectionString);
                instance = this;
            }
            catch {
                Environment.Exit(0);
            }
        }

        public static Access getInstance()
        {
            if (Access.instance == null)
            {
                lock (locker)
                {
                    if (Access.instance == null)
                    {
                        Access.instance = new Access();
                    }
                }
            }
            return Access.instance;
        }



    }
}
