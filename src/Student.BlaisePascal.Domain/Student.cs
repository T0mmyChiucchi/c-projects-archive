using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.BlaisePascal.Domain
{
    public class Student
    {
        private int _id;
        private string _name;
        private string _surname;
        List<Grade> _grades;
        HashSet<string> _subjects;

        public Student(int id, string name, string surname, List<Grade> grades, HashSet<string> subjects)
        {
            _id = id;
            _name = name;
            _surname = surname;
            _grades = grades;
            _subjects = subjects;
        }

        private void AddGrade(Grade grade)
        {
            _grades.Add(grade);
        }

        public double GetAverage(string subject)
        {
            int counter = 0;
            double sum = 0;
            for(int i = 0; i < _grades.Count; i++)
            {
                if (_grades[i].Subject == subject)
                {
                    counter++;
                    sum += _grades[i].Value;
                }
            }
            return sum / counter;
        }

        public double GetBestSubject()
        {
            double bestAverage = 0;
            for (int i = 0; i < _subjects.Count; i++)
            {
                if(GetAverage(_subjects.ElementAt(i)) > bestAverage) 
                {
                    bestAverage = GetAverage(_subjects.ElementAt(i));
                }

            }
            return bestAverage;
        }

        public double GetLongerSeriesOfFailuresInARow()
        {
            int longestFailsInARow = 0;
            for (int i = 0; i < _subjects.Count; i++)
            {
                string subj = _subjects.ElementAt(i);
                int fails = 0;
                int failsInARow = 0;
                for (int j = 0; j < _grades.Count; j++)
                {
                    if (_grades[j].Subject == subj)
                    {
                        if(_grades[j].Value < 6)
                        {
                            fails++;
                        } else
                        {
                            if(fails > failsInARow)
                            {
                                failsInARow = fails;
                            }
                            fails = 0;
                        }
                    }
                }
                if (failsInARow > longestFailsInARow)
                {
                    longestFailsInARow = failsInARow;
                }
            }
            return longestFailsInARow;
        }

    }
}
