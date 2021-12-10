using Part1.Models;
using System;
using System.Collections.Generic;

namespace Part1
{
    class Program
    {
        private static StudAnalyzeComponent InitFAM()
        {
            return new Composite(new List<Composite>
                {
                    new Composite(new List<Composite>
                        {
                            new Composite(new List<Composite>
                                {
                                    new Composite(new List<Student>
                                        {
                                            new Student
                                            {
                                                Firstname = "Petro3",
                                                Lastname = "Petrenko3",
                                                Middlename = "Petrovych3",
                                                Grades = new double[]{ 50, 100, 14, 78, 89, 56.5, 88.75 }
                                            },
                                            new Student
                                            {
                                                Firstname = "Petro4",
                                                Lastname = "Petrenko4",
                                                Middlename = "Petrovych4",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },

                                            new Student
                                            {
                                                Firstname = "Petro4",
                                                Lastname = "Petrenko4",
                                                Middlename = "Petrovych4",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },
                                        })
                                    {
                                        Naming = "KP-11",
                                    },

                                    new Composite(new List<Student>
                                        {
                                            new Student
                                            {
                                                Firstname = "Petro1",
                                                Lastname = "Petrenko1",
                                                Middlename = "Petrovych1",
                                                Grades = new double[]{ 50, 100, 14, 78, 89, 56.5, 88.75 }
                                            },
                                            new Student
                                            {
                                                Firstname = "Petro2",
                                                Lastname = "Petrenko2",
                                                Middlename = "Petrovych2",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },

                                            new Student
                                            {
                                                Firstname = "Petro0",
                                                Lastname = "Petrenko0",
                                                Middlename = "Petrovych0",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },
                                        })
                                    {
                                        Naming = "KP-12",
                                    }
                                })
                            {
                                Naming = "KP-1x",
                            },

                            new Composite(new List<Composite>
                                {
                                    new Composite(new List<Student>
                                        {
                                            new Student
                                            {
                                                Firstname = "Petro3",
                                                Lastname = "Petrenko3",
                                                Middlename = "Petrovych3",
                                                Grades = new double[]{ 50, 100, 14, 78, 89, 56.5, 88.75 }
                                            },
                                            new Student
                                            {
                                                Firstname = "Petro4",
                                                Lastname = "Petrenko4",
                                                Middlename = "Petrovych4",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },

                                            new Student
                                            {
                                                Firstname = "Petro4",
                                                Lastname = "Petrenko4",
                                                Middlename = "Petrovych4",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },
                                        })
                                    {
                                        Naming = "KP-01",
                                    },

                                    new Composite(new List<Student>
                                        {
                                            new Student
                                            {
                                                Firstname = "Petro1",
                                                Lastname = "Petrenko1",
                                                Middlename = "Petrovych1",
                                                Grades = new double[]{ 50, 100, 14, 78, 89, 56.5, 88.75 }
                                            },
                                            new Student
                                            {
                                                Firstname = "Petro2",
                                                Lastname = "Petrenko2",
                                                Middlename = "Petrovych2",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },
                                            new Student
                                            {
                                                Firstname = "Petro0",
                                                Lastname = "Petrenko0",
                                                Middlename = "Petrovych0",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },
                                        })
                                    {
                                        Naming = "KP-02",
                                    }
                                })
                            {
                                Naming = "KP-0x",
                            },

                            new Composite(new List<Composite>
                                {
                                    new Composite(new List<Student>
                                        {
                                            new Student
                                            {
                                                Firstname = "Petro3",
                                                Lastname = "Petrenko3",
                                                Middlename = "Petrovych3",
                                                Grades = new double[]{ 50, 100, 14, 78, 89, 56.5, 88.75 }
                                            },
                                            new Student
                                            {
                                                Firstname = "Petro4",
                                                Lastname = "Petrenko4",
                                                Middlename = "Petrovych4",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },

                                            new Student
                                            {
                                                Firstname = "Petro4",
                                                Lastname = "Petrenko4",
                                                Middlename = "Petrovych4",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },
                                        })
                                    {
                                        Naming = "KP-91",
                                    },

                                    new Composite(new List<Student>
                                        {
                                            new Student
                                            {
                                                Firstname = "Petro1",
                                                Lastname = "Petrenko1",
                                                Middlename = "Petrovych1",
                                                Grades = new double[]{ 50, 100, 14, 78, 89, 56.5, 88.75 }
                                            },
                                            new Student
                                            {
                                                Firstname = "Petro2",
                                                Lastname = "Petrenko2",
                                                Middlename = "Petrovych2",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },
                                            new Student
                                            {
                                                Firstname = "Petro0",
                                                Lastname = "Petrenko0",
                                                Middlename = "Petrovych0",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },
                                        })
                                    {
                                        Naming = "KP-92",
                                    }
                                })
                            {
                                Naming = "KP-9x",
                            },

                        })
                    {
                        Naming = "Computer system engineering",
                    },

                    new Composite(new List<Composite>
                        {
                            new Composite(new List<Composite>
                                {
                                    new Composite(new List<Student>
                                        {
                                            new Student
                                            {
                                                Firstname = "Petro3",
                                                Lastname = "Petrenko3",
                                                Middlename = "Petrovych3",
                                                Grades = new double[]{ 50, 100, 14, 78, 89,  }
                                            },
                                            new Student
                                            {
                                                Firstname = "Petro4",
                                                Lastname = "Petrenko4",
                                                Middlename = "Petrovych4",
                                                Grades = new double[]{ 78, 89, 56.5, 88.75 }
                                            },

                                            new Student
                                            {
                                                Firstname = "Petro4",
                                                Lastname = "Petrenko4",
                                                Middlename = "Petrovych4",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },
                                        })
                                    {
                                        Naming = "KA-11",
                                    },

                                    new Composite(new List<Student>
                                        {
                                            new Student
                                            {
                                                Firstname = "Petro1",
                                                Lastname = "Petrenko1",
                                                Middlename = "Petrovych1",
                                                Grades = new double[]{ 50, 100 }
                                            },
                                            new Student
                                            {
                                                Firstname = "Petro2",
                                                Lastname = "Petrenko2",
                                                Middlename = "Petrovych2",
                                                Grades = new double[]{ 50, 88.75 }
                                            },

                                            new Student
                                            {
                                                Firstname = "Petro0",
                                                Lastname = "Petrenko0",
                                                Middlename = "Petrovych0",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },
                                        })
                                    {
                                        Naming = "KA-12",
                                    }
                                })
                            {
                                Naming = "KA-1x",
                            },

                            new Composite(new List<Composite>
                                {
                                    new Composite(new List<Student>
                                        {
                                            new Student
                                            {
                                                Firstname = "Petro3",
                                                Lastname = "Petrenko3",
                                                Middlename = "Petrovych3",
                                                Grades = new double[]{ 50, 100, 56.5, 88.75 }
                                            },
                                            new Student
                                            {
                                                Firstname = "Petro4",
                                                Lastname = "Petrenko4",
                                                Middlename = "Petrovych4",
                                                Grades = new double[]{ 50, 88.75 }
                                            },

                                            new Student
                                            {
                                                Firstname = "Petro4",
                                                Lastname = "Petrenko4",
                                                Middlename = "Petrovych4",
                                                Grades = new double[]{ 88.75, 0, 15 }
                                            },
                                        })
                                    {
                                        Naming = "KA-01",
                                    },

                                    new Composite(new List<Student>
                                        {
                                            new Student
                                            {
                                                Firstname = "Petro1",
                                                Lastname = "Petrenko1",
                                                Middlename = "Petrovych1",
                                                Grades = new double[]{ 50, 100, 14, 78, 89, 56.5, 88.75 }
                                            },
                                            new Student
                                            {
                                                Firstname = "Petro2",
                                                Lastname = "Petrenko2",
                                                Middlename = "Petrovych2",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },

                                            new Student
                                            {
                                                Firstname = "Petro0",
                                                Lastname = "Petrenko0",
                                                Middlename = "Petrovych0",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },
                                        })
                                    {
                                        Naming = "KA-02",
                                    }
                                })
                            {
                                Naming = "KA-0x",
                            },

                            new Composite(new List<Composite>
                                {
                                    new Composite(new List<Student>
                                        {
                                            new Student
                                            {
                                                Firstname = "Petro3",
                                                Lastname = "Petrenko3",
                                                Middlename = "Petrovych3",
                                                Grades = new double[]{ 50, 100, 14, 78, 89, 56.5, 88.75 }
                                            },
                                            new Student
                                            {
                                                Firstname = "Petro4",
                                                Lastname = "Petrenko4",
                                                Middlename = "Petrovych4",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },

                                            new Student
                                            {
                                                Firstname = "Petro4",
                                                Lastname = "Petrenko4",
                                                Middlename = "Petrovych4",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },
                                        })
                                    {
                                        Naming = "KA-91",
                                    },

                                    new Composite(new List<Student>()
                                        {
                                            new Student
                                            {
                                                Firstname = "Petro1",
                                                Lastname = "Petrenko1",
                                                Middlename = "Petrovych1",
                                                Grades = new double[]{ 50, 100, 14, 88.75 }
                                            },
                                            new Student
                                            {
                                                Firstname = "Petro2",
                                                Lastname = "Petrenko2",
                                                Middlename = "Petrovych2",
                                                Grades = new double[]{ 89, 56.5, 88.75 }
                                            },

                                            new Student
                                            {
                                                Firstname = "Petro0",
                                                Lastname = "Petrenko0",
                                                Middlename = "Petrovych0",
                                                Grades = new double[]{ 14, 78, 56.5, 88.75 }
                                            },
                                        })
                                    {
                                        Naming = "KA-92",
                                    }
                                })
                            {
                                Naming = "KA-9x",
                            },

                        })
                    {
                        Naming = "Applied Math",
                    },
                })
            {
                Naming = "FPM",
            };
        }

        static void Main(string[] args)
        {
            var FAM = InitFAM();
            FAM.Display(3);
        }
    }
}
