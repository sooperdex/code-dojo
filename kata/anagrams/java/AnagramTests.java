import static org.junit.Assert.*;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import java.util.*;

public class AnagramTests {
	AnagramManager manager;

	@Before
	public void setUp() throws Exception {
		manager = new AnagramManager();
	}

	@After
	public void tearDown() throws Exception {
	}

	@Test
	public void testSwapArrayElements() {
		String text = "abcd";

		char[] chars = text.toCharArray();
		manager.swapArrayElements(chars, 0, 1);

		assertEquals("swapping index's 1 and 2", "bacd", new String(chars));
	}

	@Test
	public void testProcessingTwoLetterAnagram() {
		List<String> expected = new ArrayList<String>(Arrays.asList("ab", "ba"));

		assertEquals("2 anagrams from 2 letters", expected,
				manager.process("ab"));
	}

	@Test
	public void testProcessingThreeLetterAnagram() {
		assertEquals("6 anagrams from 3 letters", 6, manager.process("abc")
				.size());
	}
}
