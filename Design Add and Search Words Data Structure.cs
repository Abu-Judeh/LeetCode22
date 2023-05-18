public class WordDictionary {
    Dictionary<int,HashSet<string>> lookup;
    public WordDictionary() {
        lookup = new();
    }

    public void AddWord(string word) {
        int l = word.Length;

        if(lookup.ContainsKey(l))
            lookup[l].Add(word);
        else
            lookup.Add(l, new(){word});

    }

    public bool Search(string word) {
        int l = word.Length;

        if(!lookup.ContainsKey(l))
            return false;

        HashSet<string> words = lookup[l];
        foreach(string storedWords in words){
            bool isEligible = true;
            for(int i = 0; i < l; i++){
                if(storedWords[i] == '.' || word[i] == '.')
                    continue;

                if(storedWords[i] != word[i]){
                    isEligible = false;
                    break;
                }
            }

            if(isEligible)
                return true;
        }

        return false;
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */
