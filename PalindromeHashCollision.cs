using System;
using System.Collections.Generic;

class PalindromeHashCollision
{
    // Метод для проверки, является ли строка палиндромом
    static bool IsPalindrome(string str)
    {
        int left = 0;
        int right = str.Length - 1;
        
        while (left < right)
        {
            if (str[left] != str[right])
                return false;
            left++;
            right--;
        }
        return true;
    }

    // Метод для нахождения коллизии хеширования палиндромов
    static void FindPalindromeHashCollision()
    {
        // Коллекция для хранения строк с их хешами
        Dictionary<int, string> hashes = new Dictionary<int, string>();

        // Генерация палиндромов и проверка хешей
        for (int i = 1; i <= 1000; i++)
        {
            string palindrome = i.ToString() + new string(i.ToString().Reverse().ToArray()); // Простой способ создания палиндрома
            if (IsPalindrome(palindrome))
            {
                int hash = palindrome.GetHashCode();
                
                if (hashes.ContainsKey(hash))
                {
                    Console.WriteLine($"Коллизия хеширования найдена! Палиндромы с хешом {hash}:");
                    Console.WriteLine($"  {palindrome}");
                    Console.WriteLine($"  {hashes[hash]}");
                }
                else
                {
 
