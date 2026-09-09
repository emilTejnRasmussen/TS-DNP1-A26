
const string s1 = "mr owl ate my metal worm";
const string s2 = "do geese see god";
const string s3 = "was it a car or a cat i saw";
const string s4 = "murder for a jar of red rum";
const string s5 = "123454321";

const string s6 = "this is not a palindrome";
const string s7 = "what to write?";

Console.WriteLine($"{s1}: IsPalindrome={IsPalindrome(s1)}");
Console.WriteLine($"{s2}: IsPalindrome={IsPalindrome(s2)}");
Console.WriteLine($"{s3}: IsPalindrome={IsPalindrome(s3)}");
Console.WriteLine($"{s4}: IsPalindrome={IsPalindrome(s4)}");
Console.WriteLine($"{s5}: IsPalindrome={IsPalindrome(s5)}\n");

Console.WriteLine($"{s6}: IsPalindrome={IsPalindrome(s6)}");
Console.WriteLine($"{s7}: IsPalindrome={IsPalindrome(s7)}");

return;

bool IsPalindrome(string s)
{
    var left = 0;
    var right = s.Length - 1;

    while (left < right)
    {
        if (s[left] == ' ')
        {
            left++;
            continue;
        }

        if (s[right] == ' ')
        {
            right--;
            continue;
        }

        if (s[left] != s[right]) return false;
        left++; right--;
    }

    return true;
}