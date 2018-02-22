# SpamHammer
My naive solution to [CodeProject's spam filter challenge](https://www.codeproject.com/Competitions/1024/The-Machine-Learning-and-Artificial-Intelligence-C.aspx).


My thought was this: Recognizing spam might be similar to recognizing a language - something that I did ages ago for a uni project.
So I kind of clobbered together whatever I could remember about [N-grams](https://en.wikipedia.org/wiki/N-gram), in as sloppy a way as I could, and I was almost surprised when I saw that it actually worked for the test cases.

A very quick breakdown of how this works is this:
1. Training:
    1. The training messages get seperated into sequences of characters up to a specified length (i.e. N-grams)
    2. I count the appearances of each n-gram, first per message and then overall - once for the spam training data, then for the ham.
    3. I divide the count of each n-gram by the amount of test items, creating an average value per message.
2. Evaluate test data:
    1. Get the n-gram counts for the test message (the same thing we did in the learning phase)
    2. Compare the message's result to that of the average values for spam and ham data, i.e. the difference between the occurences in the test message and the average value for spam or ham.
    We subtract the difference from a score value. If an n-gram is missing from the ham / spam data completely, we subtract a specified, arbitrary amount. This results in messages getting a lower score the more differences they have when compared to the reference data.

This is very basic and probably only really works for the test cases and training data provided, but it was a fun approach. Also, I should be able to reuse most of that for the language detector part of the challenge.
