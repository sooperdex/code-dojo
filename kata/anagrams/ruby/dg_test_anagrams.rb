require './dg_anagrams'
require 'test/unit'
 
class TestHiker < Test::Unit::TestCase
 
  def test_single_letter_returns_unchanged
 
    expected = Array.new(0)
    expected.push("a")
 
    assert_equal expected, anagramsOf("a")
  end
 
  def test_two_letters_returns_two_variants
 
    expected = Array.new(0)
    expected.push("ab")
    expected.push("ba")
 
    assert_equal expected, anagramsOf("ab")
  end
 
  def test_four_letter_word_combination_explosion
   
    expected = Array.new(0)
 
    expected.push("biro")
    expected.push("bior")
    expected.push("brio")
    expected.push("broi")
    expected.push("boir")
    expected.push("bori")
    expected.push("ibro")
    expected.push("ibor")
    expected.push("irbo")
    expected.push("irob")
    expected.push("iobr")
    expected.push("iorb")
    expected.push("rbio")
    expected.push("rboi")
    expected.push("ribo")
    expected.push("riob")
    expected.push("roib")
    expected.push("robi")
    expected.push("obir")
    expected.push("obri")
    expected.push("oibr")
    expected.push("oirb")
    expected.push("orbi")
    expected.push("orib")
 
    assert_equal expected.sort, anagramsOf("biro")
  end
end
