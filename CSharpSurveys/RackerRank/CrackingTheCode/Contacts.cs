using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.RackerRank.CrackingTheCode.Contacts
{
    public class Solution
    {
        public enum Operation { add, find };
        /*
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            TrieNode trie = new TrieNode();

            for (int a0 = 0; a0 < n; a0++)
            {
                string[] tokens_op = Console.ReadLine().Split(' ');

                Operation op = (Operation)Enum.Parse(typeof(Operation), tokens_op[0]);
                
                string contact = tokens_op[1];

                switch(op)
                {
                    case Operation.add:
                        trie.AddWord(contact);
                        break;
                    case Operation.find:
                        int foundCounter = trie.FindCountPartial(contact);
                        Console.WriteLine(foundCounter);
                        break;
                }
            }
        }
        */
    }

    public class TrieNode
    {
        public char Data { get; set; }

        private readonly Dictionary<char, TrieNode> children;

        private int size;

        public TrieNode(char data) : this()
        {
            Data = data;            
        }

        public TrieNode()
        {
            children = new Dictionary<char, TrieNode>();
        }

        public void AddWord(string word)
        {
            if (word.Length > 0)
                AddWord(word, 0);
        }

        private void AddWord(string word, int index)
        {
            size++;
            if (index == word.Length)
                return;

            char current = word[index];

            TrieNode child;
            if (children.ContainsKey(current))
                child = children[current];
            else
            {
                child = new TrieNode(current);
                children.Add(current, child);                
            }

            child.AddWord(word, index + 1);
        }


        public int FindCountPartial(string partialWord)
        {
            return partialWord.Length > 0 ? FindCountPartial(partialWord, 0) : 0;
        }

        private int FindCountPartial(string partialWord, int index)
        {
            if (index == partialWord.Length)
                return size;

            char current = partialWord[index];
            TrieNode child;
            if (!children.ContainsKey(current))
                return 0;
            else
                child = children[current];


            return child.FindCountPartial(partialWord, index + 1);
        }
    }

}
   