using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LasVegasMagicShow
{
    public abstract class Person
    {
        // Instance variables
        protected int id;
        protected string name;
        protected string password;
        protected int level;

        // Constructor
        protected Person(int id, string name, string password, int level)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.level = level;
        }

        // Id properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        // Name properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Password properties
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public override string ToString()
        {
            return "id: " + id + ", name: " + name + ", password: " + password + ", level: " + level;
        }
    }
}