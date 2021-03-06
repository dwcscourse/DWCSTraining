﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soldier
{
    public class Engineer : Private, ISpecialisedSoldier
    {
        private Corps corps;
        public Corps Corps
        {
            get
            {
                return corps;
            }
        }

        private List<Repair> repairs;

        public List<Repair> Repairs 
        {
            get
            {
                return repairs;
            }
            set
            {
                repairs = value;
            }
        }

        public Engineer(int id, string firstName, string lastName, double salary, Corps corps) : base(id, firstName, lastName, salary)
        {
            this.corps = corps;
        }

        public override string ToString()
        {
            string engineerOutput = $"\nCorps: {corps} \nRepairs:";

            foreach (var repair in repairs)
            {
                engineerOutput += $"\n Part Name: {repair.Name} Hours Worked: {repair.HoursWorked}";
            }

            return base.ToString() + engineerOutput;
        }

        public List<Repair> CreateLisfOfRepairs(string input)
        {
            List<Repair> repairs = new List<Repair>();
            string[] repairsInput = input.Split(' ');

            for (int i = 6; i < repairsInput.Length; i += 2)
            {
                repairs.Add(new Repair(repairsInput[i], int.Parse(repairsInput[i + 1])));
            }

            return repairs;
        }

    }
}
