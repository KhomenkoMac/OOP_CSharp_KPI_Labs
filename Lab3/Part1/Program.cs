using Part1.Models;
using System;
using System.Collections.Generic;

namespace Part1
{
    class Program
    {
        private static Component InitFAM()
        {
            return new Faculty(new List<Course>
                {
                    new Course(new List<CourseStream>
                        {
                            new CourseStream(new List<Group>
                                {
                                    new Group(new List<Student>
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
                                        GroupName = "KP-11",
                                    },

                                    new Group(new List<Student>
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
                                        GroupName = "KP-12",
                                    }
                                })
                            {
                                StreamName = "KP-1x",
                            },

                            new CourseStream(new List<Group>
                                {
                                    new Group(new List<Student>
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
                                        GroupName = "KP-01",
                                    },

                                    new Group(new List<Student>
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
                                        GroupName = "KP-02",
                                    }
                                })
                            {
                                StreamName = "KP-0x",
                            },

                            new CourseStream(new List<Group>
                                {
                                    new Group(new List<Student>
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
                                        GroupName = "KP-91",
                                    },

                                    new Group(new List<Student>
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
                                        GroupName = "KP-92",
                                    }
                                })
                            {
                                StreamName = "KP-9x",
                            },

                        })
                    {
                        CourseName = "Computer system engineering",
                    },

                    new Course(new List<CourseStream>
                        {
                            new CourseStream(new List<Group>
                                {
                                    new Group(new List<Student>
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
                                        GroupName = "KA-11",
                                    },

                                    new Group(new List<Student>
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
                                        GroupName = "KA-12",
                                    }
                                })
                            {
                                StreamName = "KA-1x",
                            },

                            new CourseStream(new List<Group>
                                {
                                    new Group(new List<Student>
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
                                        GroupName = "KA-01",
                                    },

                                    new Group(new List<Student>
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
                                        GroupName = "KA-02",
                                    }
                                })
                            {
                                StreamName = "KA-0x",
                            },

                            new CourseStream(new List<Group>
                                {
                                    new Group(new List<Student>
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
                                        GroupName = "KA-91",
                                    },

                                    new Group(new List<Student>()
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
                                        GroupName = "KA-92",
                                    }
                                })
                            {
                                StreamName = "KA-9x",
                            },

                        })
                    {
                        CourseName = "Applied Math",
                    },
                })
            {
                FacultyName = "FPM",
            };
        }

        static void Main(string[] args)
        {
            var FAM = InitFAM();
            
            FAM.Display(3);


        }
    }
}
