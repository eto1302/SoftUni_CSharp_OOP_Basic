using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Solve
    {
        List<Trainer> trainers = new List<Trainer>();

        public void AddMember(Trainer member)
        {
            if(trainers.Where(t => t.name == member.name).FirstOrDefault()==null) trainers.Add(member);
            else trainers.Where(p => p.name == member.name).First().pokemon.Add(member.pokemon.First());
            
        }

        public void Play(string element)
        {
            foreach (var trainer in trainers)
            {
                if (trainer.pokemon.Where(p => p.element == element).FirstOrDefault() != null) trainer.badges++;
                else
                {
                    foreach (var pokemon in trainer.pokemon)
                    {
                        pokemon.health = pokemon.health - 10;
                        
                    }
                    trainer.pokemon.RemoveAll(p => p.health <= 0);
                }
            }
        }
        
        public void PrintResults()
        {
            
            foreach (var trainer in trainers.OrderByDescending(t => t.badges))
            {
                Console.WriteLine($"{trainer.name} {trainer.badges} {trainer.pokemon.Count}");
            }
        }

        
    }

