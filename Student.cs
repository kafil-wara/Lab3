public class Student {
	private string name;
	private string id;
	private string dept;
	private float cgpa;
	
	public setName(string n) {
		name = s;
		}
	public getName() {
		return name;
		}

	public setId(string i) {
		id = i;
		}
	public getId() {
		return id;
		}

	public setDept(string d) {
		dept = d;
		}
	public getDept() {
		return dept;
		}

	public setCgpa(float c) {
		cgpa = c;
		}
	public getCgpa() {
		return cgpa;
		}

		public void ShowInfo()
		{
		Console.WriteLine("Name : " + getName());
		Console.WriteLine("ID : " + getId());
		Console.WriteLine("Dept : " + getDept());
		Console.WriteLine("CGPA : " + getCgpa());
		}



}