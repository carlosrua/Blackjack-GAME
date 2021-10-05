using Blackjack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Util
{
    public static class DeckCreator
    {
        public static Deck CreateDecks()
        {
            Deck Deck = new Deck();
            List<Card> CardList = new List<Card>();
            int deckCount = 6; 

          

            for (int i = 0; i < deckCount; i++)
            {
                CardList.AddRange(new List<Card>()
                {
                new Card() { Value  = 2, Name = "Dos de Picas", Hidden=false},
                new Card() { Value = 3, Name = "tres de Picas", Hidden=false},
                new Card() { Value = 4, Name =  "cuatro de de Picas", Hidden=false},
                new Card() { Value = 5, Name = "cinco de Picas", Hidden=false},
                new Card() { Value = 6, Name = "seis de Picas", Hidden=false},
                new Card() { Value = 7, Name = "siete de Picas", Hidden=false},
                new Card() { Value = 8, Name = "ocho de Picas", Hidden=false},
                new Card() { Value = 9, Name = "nueve de Picas", Hidden=false},
                new Card() { Value = 10, Name = "diez de Picas", Hidden=false},
                new Card() { Value = 10, Name = "Jack de Picas", Hidden=false},
                new Card() { Value = 10, Name = "Reina de Picas", Hidden=false},
                new Card() { Value = 10, Name = "Rey de Picas", Hidden=false},
                new Card() { Value = 11, Name = "Ace de Picas", Hidden=false},

                new Card() { Value  = 2, Name = "dos de diamantes", Hidden=false},
                new Card() { Value = 3, Name = "tres de diamantes", Hidden=false},
                new Card() { Value = 4, Name =  "cuatro de diamantes", Hidden=false},
                new Card() { Value = 5, Name = "cinco de diamantes", Hidden=false},
                new Card() { Value = 6, Name = "seis de diamantes", Hidden=false},
                new Card() { Value = 7, Name = "Siete de diamantes", Hidden=false},
                new Card() { Value = 8, Name = "ocho de diamantes", Hidden=false},
                new Card() { Value = 9, Name = "Nueve de diamantes", Hidden=false},
                new Card() { Value = 10, Name = "diez de diamantes", Hidden=false},
                new Card() { Value = 10, Name = "Jack de diamantes", Hidden=false},
                new Card() { Value = 10, Name = "Reina de diamantes", Hidden=false},
                new Card() { Value = 10, Name = "Rey de diamantes", Hidden=false},
                new Card() { Value = 11, Name = "Ace de diamantes", Hidden=false},

                new Card() { Value  = 2, Name = "dos de treboles", Hidden=false},
                new Card() { Value = 3, Name = "tres de treboles", Hidden=false},
                new Card() { Value = 4, Name =  "cuatro de treboles", Hidden=false},
                new Card() { Value = 5, Name = "cinco de treboles", Hidden=false},
                new Card() { Value = 6, Name = "Seis de treboles", Hidden=false},
                new Card() { Value = 7, Name = "Siete de treboles", Hidden=false},
                new Card() { Value = 8, Name = "ocho de treboles", Hidden=false},
                new Card() { Value = 9, Name = "nueve de treboles", Hidden=false},
                new Card() { Value = 10, Name = "diez de treboles", Hidden=false},
                new Card() { Value = 10, Name = "Jack de treboles", Hidden=false},
                new Card() { Value = 10, Name = "Reina de treboles", Hidden=false},
                new Card() { Value = 10, Name = "Rey de treboles", Hidden=false},
                new Card() { Value = 11, Name = "Ace de treboles", Hidden=false},

                new Card() { Value  = 2, Name = "dos de corazones", Hidden=false},
                new Card() { Value = 3, Name = "tres de corazones", Hidden=false},
                new Card() { Value = 4, Name =  "cuatro de corazones", Hidden=false},
                new Card() { Value = 5, Name = "cinco de corazones", Hidden=false},
                new Card() { Value = 6, Name = "seis de corazones", Hidden=false},
                new Card() { Value = 7, Name = "Siete de corazones", Hidden=false},
                new Card() { Value = 8, Name = "ocho de corazones", Hidden=false},
                new Card() { Value = 9, Name = "nueve de corazones", Hidden=false},
                new Card() { Value = 10, Name = "diez de corazones", Hidden=false},
                new Card() { Value = 10, Name = "Jack de corazones", Hidden=false},
                new Card() { Value = 10, Name = "Reina de corazones", Hidden=false},
                new Card() { Value = 10, Name = "Rey de corazones", Hidden=false},
                new Card() { Value = 11, Name = "Ace de corazones", Hidden=false}
                });
                DeckShuffler.ShuffleDeck(CardList);
                Deck.CardStack = new Stack<Card>(CardList);
            }
            return Deck;
        }
    }
}
