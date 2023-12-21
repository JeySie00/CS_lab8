using System;
using System.Net.NetworkInformation;
using System.Xml.Serialization;
using Animal;

namespace part_01.deseriakize
{
    class Programm
    {
        static void Main()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Pig));

            using (FileStream fs = new FileStream("/Users/yankovezin/Downloads/Lab_08/Lab_08/bin/Debug/net6.0/pig.xml", FileMode.Open))
            {
                Pig? pig = xmlSerializer.Deserialize(fs) as Pig;
                Console.WriteLine($"Type: {pig?.WhatAnimal}, Name: {pig?.Name}, Country: {pig?.Country}, Hide from: {pig.HideFromOtherAnimal}, Favorite food: {pig.FavoriteFood}");
            }
        }
    }
}