the 'Complex Patterns' folder consists of pattern definitions for patterns which correspond to sentence structures surrounding a given phrase or word, and consider the positioning of these words in addition to their presence.

The 'Format Free Patterns' folder consists of pattern definitions for patterns which correspond to simple patterns that only look for the presence of a given word in the user's input. These patterns look for relatively specific words which prompt a concrete response.

the ComplexPattern file is the parent class to all complex patterns, and likewise the FormatFreePattern file is the parent class to all format-free patterns. Both ComplexPattern and FormatFreePattern derive from the class 'Pattern' (in the Pattern file). 

the StringTransformer file contains the class with functionality to replace certain key words from user input with different forms of the given word so that they can be processed by the pattern-matching facility and used to generate a response. For example, the string 'I AM' from user input would turn into 'YOU ARE' when a response is generated; 'I' changes to 'YOU', and 'AM' changes to 'ARE'.

