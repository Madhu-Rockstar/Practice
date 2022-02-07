using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Team
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public double salary { get; set; }
        public Gender gender { get; set; }
    }
    class TeamManager
    {
        private Team[] _teams;
        public TeamManager(int size)
        {
            _teams = new Team[size];
            _teams[0] = new Team { id = 1,name="madhu",address="Banglore",salary=100000,gender=Gender.mr };
            _teams[1] = new Team { id=2,name="hemanth",address="mumbai",salary=70000,gender=Gender.mr};
            _teams[2]= new Team { id = 3, name = "lasya", address = "hyderabad", salary = 50000, gender = Gender.ms };
            _teams[3]=new Team { id = 4, name = "bavana", address = "chennai", salary = 40000, gender = Gender.ms };
            _teams[4] = new Team { id = 5, name = "shiva", address = "kolkatha", salary = 60000, gender = Gender.mr };
            _teams[5] = new Team { id = 6, name = "surya", address = "delhi", salary = 65000, gender = Gender.mr };
        }
        public void Addmember(Team t)
        {
            if (!teamidvalid(t.id))
            {
                Console.WriteLine("Team id is already exists:");
                return;
            }
            for(int i = 0; i <= _teams.Length; i++)
            {
                if (_teams[i] == null)
                {
                    _teams[i] = new Team { id = t.id, name = t.name, address = t.address, gender = t.gender, salary = t.salary };
                    return;
                }
            }
            Console.WriteLine("here there is no vacency:");
            
        }
        private bool teamidvalid(int id)
        {

            foreach(Team i in _teams)
            {
                if ( i!=null && i.id==id)
                {
                    return false;
                }
            }
            return true;
        }
        public void Updatemember(Team t)
        {
            for(int i = 0; i < _teams.Length; i++)
            {
                if(_teams[i].id==t.id && _teams[i] != null)
                {
                    _teams[i] = new Team { name=t.name,address=t.address,salary=t.salary};
                    return;
                }
                
            }
            Console.WriteLine("That id is already exists..can u update onemore");
        }
        public Team Findmember(int id)
        {
            for(int i = 0; i < _teams.Length; i++)
            {
                if ( _teams[i]!=null &&_teams[i].id==id)
                {
                    return _teams[i];
                }
            }
            Console.WriteLine("No results found here....plse go man");
            return null;
        }
        
    }

    class Employeemanagerapp
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of the employee");
            int size = int.Parse(Console.ReadLine());
            TeamManager tit = new TeamManager(size);

            tit.Addmember(new Team { id=7,name="Ramcharan",salary=90000,address="us",gender=Gender.mr});

            tit.Updatemember(new Team {id=7,name="pavankalyan",salary=95000,address="india",gender=Gender.mr });

            Team res = tit.Findmember(6);
            if (res != null)
            {
                Console.WriteLine("See the below the results:");
                Console.WriteLine($"Name: {res.name} and address: {res.address}");
            }
        }
    }
}

