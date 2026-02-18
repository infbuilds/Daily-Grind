class Footballer:
    def __init__(self, first_name, last_name, age, overall_rating=75):
        self.first_name = first_name
        self.last_name = last_name
        self.age = age
        self.overall_rating = overall_rating

    
    def __str__(self):
        return f"{self.first_name} {self.last_name} (Age: {self.age}, Rating: {self.overall_rating})"

    
    def __eq__(self, other):
        if not isinstance(other, Footballer):
            return False
        return self.first_name == other.first_name and self.last_name == other.last_name

    
    def __add__(self, other):
        combined_name = f"Fusion-{self.first_name[:3]}{other.first_name[:3]}"
        combined_last_name = f"{self.last_name}-{other.last_name}"
        avg_age = (self.age + other.age) // 2
        new_rating = min(100, (self.overall_rating + other.overall_rating) // 1.5) # Yetenek bonusu
        return Footballer(combined_name, combined_last_name, avg_age, int(new_rating))

    
    def __lt__(self, other):
        return self.overall_rating < other.overall_rating

    # Büyüktür kontrolü
    def __gt__(self, other):
        return self.overall_rating > other.overall_rating


player1 = Footballer("Hakan", "Sukur", 40, 85)
player2 = Footballer("Hakan", "Sukur", 34, 82)

print(f"Are they the same player? {player1 == player2}")


super_player = player1 + player2
print(f"New Generated Player: {super_player}")


print(f"Is {player1.first_name} better than the other? {player1 > player2}")
