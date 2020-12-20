﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t23
{
    /*
    * Для всех приватных полей класса Walkman создайте и реализуйте соответствующие сеттеры и геттеры.
    * Для сеттера поля soundVolume необходимо:
    * 1) Устанавливать значение 0, если передано отрицательное значение.
    * 2) Устанавливать значение 100, если передано значение большее 100.
    * В сеттере поля currentSong необходимо устанавливать значение полю isOn - false, если текущее значение поля null или пустая строка.
    * Шаблон задачи изменять нельзя.
    */
    public class Walkman
    {
        private int soundVolume = 50;
        private string currentSong = "Oooo...you touch my tralala";
        public bool isOn = true;
        public static void Main(string[] args)

        {
        }
        /* Добавьте свой код ниже */
        public void SetsoundVolume(int soundVolume)
        {
            if (soundVolume<0)
            {
                this.soundVolume = 0;
            }
            if (soundVolume > 100)
            {
                this.soundVolume = 100;
            }
        }
        public void SetcurrentSong(string currentSong)
        {
            if (currentSong == null || currentSong == "")
            {
                this.isOn = false;
            }
        }
    }
}