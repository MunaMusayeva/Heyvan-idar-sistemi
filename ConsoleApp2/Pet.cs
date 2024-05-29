using System.Xml.Linq;

namespace ConsoleApp2;

public abstract class Pet
{
    public string Nickname { get; set; }
    public int Age { get; set; }
    public Gender Gender { get; set; }
    public int Energy { get; set; }
    public decimal Price { get; set; }
    public int MealQuantity { get; set; }
    public Pet(string nickname, int age, Gender gender, int energy, decimal price, int mealQuantity)
    {
        Nickname = nickname;
        Age = age;
        Gender = gender;
        Energy = energy;
        Price = price;
        MealQuantity = mealQuantity;
    }

    public abstract void Eat();
    public abstract void Sleep();
    public abstract void Play();
    public override string ToString() =>
       $"Nickname:{Nickname}\nAge:{Age}\nGender:{Gender}\nEnergy:{Energy}\nPrice:{Price}\nMeal Quatity:{MealQuantity}";

}
