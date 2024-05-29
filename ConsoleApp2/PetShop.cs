namespace ConsoleApp2;

public class PetShop
{
    public List<Pet> Pets { get; set; } = new List<Pet>();
    public void AddPet(Pet pet)
    {
        Pets.Add(pet);
    }
    public (int FishMealQuantity, int CatMealQuantity, int DogMealQuantity, int BirdMealQuantity) GetTotalMealQuantity()
    {
        int totalFishQuantity = 0;
        int totalCatQuantity = 0;
        int totalDogQuantity = 0;
        int totalBirdQuantity = 0;

        foreach (var pet in Pets)
        {
            if (pet is Fish fish)
            {
                totalFishQuantity += fish.MealQuantity;
            }
            else if (pet is Cat cat)
            {
                totalCatQuantity += cat.MealQuantity;
            }
            else if (pet is Dog dog)
            {
                totalDogQuantity += dog.MealQuantity;
            }
            else if (pet is Bird bird)
            {
                totalBirdQuantity += bird.MealQuantity;
            }
        }

        return (totalFishQuantity, totalCatQuantity, totalDogQuantity, totalBirdQuantity);
    }
    public (decimal CatPrice, decimal DogPrice, decimal BirdPrice, decimal FishPrice) GetTotalPetPrice()
    {
        decimal totalCatPrice = 0;
        decimal totalDogPrice = 0;
        decimal totalBirdPrice = 0;
        decimal totalFishPrice = 0;

        foreach (var pet in Pets)
        {
            if (pet is Cat)
            {
                totalCatPrice += pet.Price;
            }
            else if (pet is Dog)
            {
                totalDogPrice += pet.Price;
            }
            else if (pet is Bird)
            {
                totalBirdPrice += pet.Price;
            }
            else if (pet is Fish)
            {
                totalFishPrice += pet.Price;
            }
        }

        return (totalCatPrice, totalDogPrice, totalBirdPrice, totalFishPrice);
    }

}
