

def anagramsOf(word)

	anagrams = Array.new([])
	
	word.chars.to_a.permutation.map(&:join).uniq.each.do | anagram |
	
		anagrams.push(anagram)
	
	end 
	
	anagrams.sort
	
end
