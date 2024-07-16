using NestedObjects;

Advisor compSciAdvisor = new Advisor()
{
	Email = "Annemarie@cptc.edu",
	FullName = "Annemarie Smith",
	OfficeLocation = "b17 Rm 150"
};

Student stu1 = new Student()
{
	FirstName = "Homer",
	LastName = "Simpson",
	DateOfBirth = new DateOnly(2000, 3, 20),
	AssignedAdvisor = compSciAdvisor,
	PhoneNumber = "2537468916",
	SchoolEmail = "Homer.Simpson.cptc.due"
};

Console.WriteLine($"Student: {stu1.FirstName} has {stu1.AssignedAdvisor.FullName} ");