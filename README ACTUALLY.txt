Tools 2 Localization

========Revision=========
I have finally understood Scriptable Objects and using them with a large text asset.

Now my text file gets imported to an asset file that is mapped to a data class I've created 
thats a kind of scriptable object. The user puts in that language library file, and the editor 
parses it for the content you want to see. Now you can put a UseScriptableTest script onto a text 
object and it will look for the default language library, or throw an error if its missing. 
Whether you want to change the library or add the default one, you can atach the asset to this 
script and then that component will allow you to include "Text". Whatever you include in the 
text here will scan the library asset, and return the translation based on the library 
specific selected language.

I believe that should cover:
	- Library is imported as a Unity Asset
	- New text objects can have the library translations applied to them (tested)

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