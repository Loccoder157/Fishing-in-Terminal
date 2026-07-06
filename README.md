# Fishing Terminal Game Design

## 1. Player

-   Level, EXP, Coins
-   Current Rod, Current Bait, Current Region
-   Stats: Luck, Fishing Power
-   Unlock regions by level.

## 2. Fishing Loop

1.  Choose region
2.  Choose rod
3.  Choose bait
4.  Cast line
5.  Wait (random)
6.  Roll rarity
7.  Roll fish
8.  Roll size/weight
9.  Reward EXP & coins
10. Store fish

## 3. Rods

Fields: - Name - Price - Required Level - Luck - Power - Durability -
Rare Bonus - Size Bonus

## 4. Fish

Fields: - Name - Region - Min/Max Size - Min/Max Weight - Required
Level - Rarity - Sell Price - EXP - Favorite Bait - Time - Weather

## 5. Baits

-   Name
-   Price
-   Luck Bonus
-   Rare Bonus
-   Target Fish

## 6. Regions

River, Lake, Ocean, Swamp, Ice Lake, Volcano, Deep Sea

Each region: - Required Level - Fish List - Unlock Cost - Weather
Modifier

## 7. Shop

Buy: - Rods - Baits - Backpack - Boat Sell: - Fish - Treasure

## 8. Inventory

-   Fish
-   Rods
-   Baits
-   Materials
-   Treasure

## 9. Fish Book

Track: - Total caught - Largest size - Largest weight - Completion %

## 10. Quests

Daily and permanent quests.

## 11. Achievements

-   First Fish
-   100 Fish
-   Legendary Hunter
-   Millionaire

## 12. Weather

Sunny, Rain, Fog, Storm

## 13. Time

Morning, Noon, Evening, Night

## 14. Economy

Coins from fish, quests, treasure.

## 15. Save

Save JSON: - Player - Inventory - Regions - Rods - Fish Book -
Achievements

## Suggested Folder Structure

``` text
FishingTerminal/
│
├── Program.cs
├── Data/
├── Models/
│   ├── Fish.cs
│   ├── Rod.cs
│   ├── Bait.cs
│   ├── Player.cs
│   ├── Region.cs
│   └── Inventory.cs
├── Services/
│   ├── FishingService.cs
│   ├── SaveService.cs
│   ├── ShopService.cs
│   └── QuestService.cs
├── UI/
└── Saves/
```

## Development Roadmap

### Phase 1

-   Fishing
-   Player
-   Fish
-   Rod
-   Shop
-   Inventory
-   Save

### Phase 2

-   Regions
-   Baits
-   Fish Book
-   Player Level

### Phase 3

-   Quests
-   Achievements
-   Weather
-   Time
-   Treasure
-   Titles
