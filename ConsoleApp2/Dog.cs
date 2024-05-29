namespace ConsoleApp2;

public class Dog : Pet
{
    public Dog(string nickname, int age, Gender gender, int energy, decimal price, int mealQuantity) : base(nickname, age, gender, energy, price, mealQuantity)
    {
    }

    public override void Eat()
    {
        MealQuantity++;
        Energy += 10;
        Price += 5;
    }
    public override void Sleep()
    {
        Energy += 20; 
    }
    public override void Play()
    {
        Energy -= 15;
        if (Energy <= 0)
        {
            Sleep();
        }
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
