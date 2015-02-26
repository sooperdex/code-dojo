import java.util.*;

public class AnagramManager {

	List<String> anagrams;

	void swapArrayElements(char[] chars, int source, int target) {
		char temp = chars[source];

		chars[source] = chars[target];
		chars[target] = temp;
	}

	List<String> process(String text) {
		anagrams = new ArrayList<String>();

		generateAnagrams(text.length(), text.toCharArray());

		return anagrams;
	}

	private void generateAnagrams(int count, char[] chars) {
		if (count == 1) {
			anagrams.add(new String(chars));

		} else {
			for (int i = 0; i < count; i++) {
				generateAnagrams(count - 1, chars);
				if (count % 2 == 0) {
					swapArrayElements(chars, i, count - 1);
				} else {
					swapArrayElements(chars, 1, count - 1);
				}
			}
		}
	}
}
