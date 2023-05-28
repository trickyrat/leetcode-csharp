// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCodecsharp.DataStructure;

/// <summary>
/// Dictionary Tree class
/// </summary>
public class Trie
{
    TrieNode Root
    {
        get; set;
    }
    public Trie()
    {
        Root = new TrieNode();
    }

    public void Insert(string word)
    {
        var node = Root;
        for (var i = 0; i < word.Length; i++)
        {
            var currentChar = word[i];
            if (!node.ContainsKey(currentChar))
            {
                node.Put(currentChar, new TrieNode());
            }
            node = node.Get(currentChar);
        }
        node.IsEnd = true;
    }


    public bool Search(string word)
    {
        var node = SearchPrefix(word);
        return node != null && node.IsEnd;
    }
    private TrieNode SearchPrefix(string word)
    {
        var node = Root;
        for (var i = 0; i < word.Length; i++)
        {
            var currLetter = word[i];
            if (node.ContainsKey(currLetter))
                node = node.Get(currLetter);
            else
                return null;
        }
        return node;
    }

    public bool StartWith(string prefix)
    {
        var node = SearchPrefix(prefix);
        return node != null;
    }
}
/// <summary>
/// Trie Node
/// </summary>
public class TrieNode
{
    public string Word
    {
        get; set;
    }
    public TrieNode[] Links;

    // a-z lowercase
    private static readonly int R = 26;

    public bool IsEnd
    {
        get; set;
    }

    public TrieNode()
    {
        Links = new TrieNode[R];
    }

    public bool ContainsKey(char ch)
    {
        return Links[ch - 'a'] != null;
    }

    public TrieNode Get(char ch)
    {
        return Links[ch - 'a'];
    }

    public void Put(char ch, TrieNode node)
    {
        Links[ch - 'a'] = node;
    }
}
