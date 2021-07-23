﻿using System;

namespace ConsoleApp2.FactoryPattern {
    abstract class FurnitureFactory {
        public string Name { get; }

        public FurnitureFactory(string name) {
            Name = name;
            Console.WriteLine(Name + " was been created");
        }

        public abstract Furniture CreateTable();
        public abstract Furniture CreateChair();
    }
}