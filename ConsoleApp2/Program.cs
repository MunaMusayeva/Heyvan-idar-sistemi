using ConsoleApp2;

class Proqram
{
    static void Main(string[] args)
    {
        PetShop petShop = new PetShop();
        Cat cat1 = new Cat("Tom", 1, Gender.Male, 35,50,0);
        Cat cat2 = new Cat("Tom", 1, Gender.Male, 35, 50, 0);
        Dog dog1 = new Dog ("Lucy",2,Gender.Female,100,100,0);
        Fish fish1 = new Fish("Nemo", 3, Gender.Male, 100, 200, 0);
        Bird bird1 = new Bird("Ruby", 4, Gender.Female, 100, 300, 0);
        petShop.AddPet(cat1);
        petShop.AddPet(cat2);
        petShop.AddPet(dog1);
        petShop.AddPet(fish1);
        petShop.AddPet(bird1);

        
        cat1.Play();
        cat1.Play();
        cat1.Play();
        cat1.Eat();
        cat1.Eat();
       




        dog1.Eat();
        dog1.Play();

        fish1 .Eat();
        fish1.Play();

        bird1.Eat();
        bird1.Play();

        Console.WriteLine(cat1.ToString());
        var totalMealQuantity = petShop.GetTotalMealQuantity();
        Console.WriteLine($"Total Cat Meal Quantity: {totalMealQuantity.CatMealQuantity}");
        var totalPetPrice = petShop.GetTotalPetPrice();
        Console.WriteLine($"Total Cat Price: {totalPetPrice.CatPrice}");

    }
}


