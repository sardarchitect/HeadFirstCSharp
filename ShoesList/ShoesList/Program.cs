﻿using ShoesList;

ShoeCloset shoeCloset = new ShoeCloset();

while (true) {
    shoeCloset.PrintShoes();
    Console.Write("\nPress 'a' to add or 'r' to remove a shoe: ");
    char keyPress = Console.ReadKey(true).KeyChar;

    switch (keyPress)
    {
        case 'a':
        case 'A':
            shoeCloset.AddShoe();
            break;
        case 'r':
        case 'R':
            shoeCloset.RemoveShoe();
            break;
        default:
            return;
    }
}

