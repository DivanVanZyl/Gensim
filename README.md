# Gensim
Animal Generation Simulator

This program simulates an ${x}$ amount of generations of an animal, according to that animal's breeding mechanics.

The number of organisms per generation is counted, producing a number pattern.

Examples of these number patterns are Fibonacci sequence for bees🐝 and powers of 2 for humans👶🏼.

![CalculatingPuzzledGIF](https://github.com/DivanVanZyl/Gensim/assets/5897077/4b7c6526-0002-4dc6-aa5c-f705aa429792)

Confused? It's actually quite simple. Let me ellaborate: You are a human...or a computer, but in such a case, biological generations would not apply to you, so human will be assumaed here. As a human, you have exacty two parents. This is a biological fact in the sense that it is required as part of the breeding mechanic of the human species, ie the parental requirements for a male of female human, is both a male and female parent (one of each).

This you will see represented in the Man and Woman implementations of IGender:

```
this.RequiredParents = new List<Type>
            {
                typeof(Woman),
                typeof(Man)
            };
```

One of the implications of this, is that if I count all of my parents, the number will always be 2. And if I count all of my grandparents, the number will always be 4. And their parents, will be 8, and so on. This is the same as ${2^n}$ !

But not all animals have two genders and two parents. As for my other example, bees. They have 3 genders, whom have different parental requirements. Here is an example from my Queen implementation of IGender:

```
this.RequiredParents = new List<Type>
            {
                typeof(Queen),
                typeof(Drone)
            };
```
The Queen also has two required genders, but 2/3 total genders for that species. As for the Drone gender, it as a peculuar parental requirement:

```
this.RequiredParents = new List<Type>
            {
                typeof(Queen)
            };
```

The implication of the bee's different genders and gender mechanics, is of course that the number pattern resulting from counting their ancestors is different than ours. Theirs is in fact: $\displaystyle F_{n}=F_{n-1}+F_{n-2}$ !

I got the idea for this progam, while reading "The Maths Book - Big Ideas Simply Explained".
