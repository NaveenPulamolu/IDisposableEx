using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisposableDemo
{
    public class User : IDisposable
    {
        public int id { get; protected set; }
        public string name { get; protected set; }
        public string pass { get; protected set; }

        public User(int userID)
        {
            id = userID;
        }
        public User(string Username, string Password)
        {
            name = Username;
            pass = Password;
        }

        // Other functions go here...

        public void Dispose()
        {
            Console.WriteLine("{0}{1}{2}", name, "+", pass);
            Dispose(true);
            GC.SuppressFinalize(this);
            Console.WriteLine("The value after disposed {0}{1}{2}", name, "+", pass);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
                {
                    id = 0;
                    name = String.Empty;
                    pass = String.Empty;
                }
                disposing = true;
        }
        ~User() // In Runtime this destructor is treated as a finalize method.
        {
            Dispose(false);
        }

        // GC Does not know about unmanaged resources, such as files and streams. If 
        // we do not clean them explicitly, we will end up with memory leaks and locked resources.
    }
    }
