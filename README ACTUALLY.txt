Tools 2 Localization

This project i focused on localization for buttons and interface elements.

Essentially there is a plain-text lexicon that the language person updates 
in some notepad. Then a Language Controller parses the file to understand 
what the words are in the other languages. This script can be used to directly 
change the language of the entire game. Finally, there is a Text Add On that 
gets put onto text elements and allows you to enter the text to display, and 
have it spit back in real time what the translated text is based on the 
shared lexicon.

Technically speaking, a tabular text file hosts rows dedicated to words and 
columns dedicated to the word in different languages. The LibraryController 
class parses this file for its content, associating the other languages with 
the english word. This class will be hosted on an empty game object so that all 
text objects will have access to its content. The TextAddOn class allows a 
non_technical user to simply drag and drop a script onto a text object and use
a customized inspector to enter what the text should read. The class then uses 
the shared LibraryController to look up the word in the set language and display 
the translated text back in a read-only format (this will ouput "Not in library" 
if the word is not yet recorded). All together, the user can add this TextAddOn 
to multiple text objects, and when the LibraryController's selected language 
changes, all text objects will be translated in the next run of their 
update function.