using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Eliza
{
    /// <summary>
    /// Simulates a psychiatrist.
    /// </summary>
    public class Eliza : IEliza
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Eliza" /> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public Eliza
            (ILogger logger)
        {
            // Initialize Eliza so that it can be used
            this._logger = logger;
            this.Initialize();
        }

        #endregion

        #region Public properties

        /// <summary>
        /// Gets the message used to welcome a user to Eliza.
        /// </summary>
        public string WelcomeMessage {
            get { return "WELCOME!  PLEASE TELL ME YOUR PROBLEM."; }
        }

        /// <summary>
        /// Gets the synonyms that Eliza recognizes.
        /// </summary>
        public Dictionary<string, List<string>> Synonyms {
            get;
            private set;
        }

        /// <summary>
        /// Gets Eliza's memory.
        /// </summary>
        public Memory Memory {
            get;
            private set;
        }

        #endregion

        #region Public methods

        /// <inheritdoc />
        public void EnableLogging
            (bool enable)
        {
            this._logger.EnableLogging(enable);
        }

        /// <inheritdoc />
        public string GetResponse
            (string input,
             out bool conversationHasEnded)
        {
            // Ignore empty inputs
            conversationHasEnded = false;
            if (input != null) {
                input = input.Trim();
            }
            if (string.IsNullOrEmpty(input)) {
                return Eliza.EmptyInputMessage;
            }

            // Make input uppercase so we don't have to handle mixed-case text
            input = input.ToUpper();

            // Replace multiple spaces with a single space to make it easier for
            // a pattern to search for a phrase
            while (input.Contains("  ")) {
                input = input.Replace("  ", " ");
            }

            // Remove punctuation marks so we don't have to deal with them
            input = input.Replace(".", string.Empty)
                            .Replace(",", string.Empty)
                            .Replace(";", string.Empty)
                            .Replace("?", string.Empty)
                            .Replace("!", string.Empty);

            // Return "good bye" if the user ended the conversation
            conversationHasEnded = Eliza.DoesInputImplyEndOfConversation(input);
            if (conversationHasEnded) {
                return Eliza.GetGoodByeResponse();
            }

            // Find matching pattern - if none, use the generic response pattern
            Pattern pattern = FindMatchingPatternForInput (input);
            if (pattern == null) {
                pattern = this._patterns.Single(p => p.GetType() == typeof(GenericResponsePattern));
            }
            string response = pattern.GenerateResponse(input, this.Synonyms, this.Memory, this._logger);
                
            // Get the pattern's response - if null, use the generic response pattern
            if (response == null) {
                pattern = this._patterns.Single(p => p.GetType() == typeof(GenericResponsePattern));
                this._logger.Info(string.Format("GetResponse: Selected pattern {0} to handle null response", pattern.GetType().Name));
                response = pattern.GenerateResponse(input, this.Synonyms, this.Memory, this._logger);
            }
            return response;
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        private void Initialize()
        {
            // Add format free patterns
            this._patterns = new List<Pattern>();
            this._patterns.Add(new AlikePattern());
            this._patterns.Add(new AlwaysPattern());
            this._patterns.Add(new BecausePattern());
            this._patterns.Add(new ComputerPattern());
            this._patterns.Add(new DreamPattern());
            this._patterns.Add(new ForeignPattern());
            this._patterns.Add(new HelloPattern());
            this._patterns.Add(new NamePattern());
            this._patterns.Add(new NoPattern());
            this._patterns.Add(new PerhapsPattern());
            this._patterns.Add(new SorryPattern());
            this._patterns.Add(new WhatPattern());
            this._patterns.Add(new YesPattern());

            // Add complex patterns
            this._patterns.Add(new AmPattern());
            this._patterns.Add(new ArePattern());
            this._patterns.Add(new CanPattern());
            this._patterns.Add(new DreamedPattern());
            this._patterns.Add(new GenericResponsePattern());
            this._patterns.Add(new EveryonePattern());
            this._patterns.Add(new IfPattern());
            this._patterns.Add(new IPattern());
            this._patterns.Add(new LikePattern());
            this._patterns.Add(new MyPattern());
            this._patterns.Add(new RememberPattern());
            this._patterns.Add(new WasPattern());
            this._patterns.Add(new WerePattern());
            this._patterns.Add(new WhyPattern());
            this._patterns.Add(new YouPattern());
            this._patterns.Add(new YourPattern());

            // Initialize the synonyms
            this.InitializeSynonyms();

            // Initialize the memory
            this.Memory = new Memory();
        }

        /// <summary>
        /// Initializes the synonyms.
        /// </summary>
        private void InitializeSynonyms()
        {
            // @BELIEF
            this.Synonyms = new Dictionary<string, List<string>>();
            this.Synonyms.Add("@BELIEF", new List<string>());
            this.Synonyms["@BELIEF"].Add("FEEL");
            this.Synonyms["@BELIEF"].Add("THINK");
            this.Synonyms["@BELIEF"].Add("BELIEVE");
            this.Synonyms["@BELIEF"].Add("WISH");

            // @FAMILY
            this.Synonyms.Add("@FAMILY", new List<string>());
            this.Synonyms["@FAMILY"].Add("MOTHER");
            this.Synonyms["@FAMILY"].Add("MOM");
            this.Synonyms["@FAMILY"].Add("FATHER");
            this.Synonyms["@FAMILY"].Add("DAD");
            this.Synonyms["@FAMILY"].Add("SISTER");
            this.Synonyms["@FAMILY"].Add("SISTERS");
            this.Synonyms["@FAMILY"].Add("BROTHER");
            this.Synonyms["@FAMILY"].Add("BROTHERS");
            this.Synonyms["@FAMILY"].Add("WIFE");
            this.Synonyms["@FAMILY"].Add("CHILDREN");
            this.Synonyms["@FAMILY"].Add("CHILD");
            this.Synonyms["@FAMILY"].Add("SON");
            this.Synonyms["@FAMILY"].Add("SONS");
            this.Synonyms["@FAMILY"].Add("DAUGHTER");
            this.Synonyms["@FAMILY"].Add("DAUGHTERS");
            this.Synonyms["@FAMILY"].Add("UNCLE");
            this.Synonyms["@FAMILY"].Add("UNCLES");
            this.Synonyms["@FAMILY"].Add("AUNT");
            this.Synonyms["@FAMILY"].Add("AUNTS");
            this.Synonyms["@FAMILY"].Add("AUNTY");
            this.Synonyms["@FAMILY"].Add("AUNTIES");
            this.Synonyms["@FAMILY"].Add("NEWPHEW");
            this.Synonyms["@FAMILY"].Add("NEWPHEWS");
            this.Synonyms["@FAMILY"].Add("NIECE");
            this.Synonyms["@FAMILY"].Add("NIECES");
            this.Synonyms["@FAMILY"].Add("GRANDMOTHER");
            this.Synonyms["@FAMILY"].Add("GRANDMOTHERS");
            this.Synonyms["@FAMILY"].Add("GRANDFATHER");
            this.Synonyms["@FAMILY"].Add("GRANDFATHERS");

            // @DESIRE
            this.Synonyms.Add("@DESIRE", new List<string>());
            this.Synonyms["@DESIRE"].Add("DESIRE");
            this.Synonyms["@DESIRE"].Add("WANT");
            this.Synonyms["@DESIRE"].Add("NEED");
            this.Synonyms["@DESIRE"].Add("CRAVE");

            // @SAD
            this.Synonyms.Add("@SAD", new List<string>());
            this.Synonyms["@SAD"].Add("SAD");
            this.Synonyms["@SAD"].Add("UNHAPPY");
            this.Synonyms["@SAD"].Add("DEPRESSED");
            this.Synonyms["@SAD"].Add("SICK");

            // @HAPPY
            this.Synonyms.Add("@HAPPY", new List<string>());
            this.Synonyms["@HAPPY"].Add("HAPPY");
            this.Synonyms["@HAPPY"].Add("ELATED");
            this.Synonyms["@HAPPY"].Add("GLAD");

            // @EVERYONE
            this.Synonyms.Add("@EVERYONE", new List<string>());
            this.Synonyms["@EVERYONE"].Add("EVERYONE");
            this.Synonyms["@EVERYONE"].Add("EVERYBODY");
            this.Synonyms["@EVERYONE"].Add("NOONE");
            this.Synonyms["@EVERYONE"].Add("NOBODY");

            // @BE
            this.Synonyms.Add("@BE", new List<string>());
            this.Synonyms["@BE"].Add("AM");
            this.Synonyms["@BE"].Add("IS");
            this.Synonyms["@BE"].Add("ARE");
            this.Synonyms["@BE"].Add("WAS");

            // @LOVE_LIKE
            this.Synonyms.Add("@LOVELIKE", new List<string>());
            this.Synonyms["@LOVELIKE"].Add("LOVE");
            this.Synonyms["@LOVELIKE"].Add("LIKE");

            // @LOVE
            this.Synonyms.Add ("@LOVE", new List<string> ());
            this.Synonyms["@LOVE"].Add ("LOVE");
            this.Synonyms["@LOVE"].Add ("LIKE");
            this.Synonyms["@LOVE"].Add ("ADORE");
            this.Synonyms["@LOVE"].Add ("REVERE");
            this.Synonyms["@LOVE"].Add ("ENJOY");
            this.Synonyms["@LOVE"].Add ("CHERISH");

            // @HATE
            this.Synonyms.Add ("@HATE", new List<string> ());
            this.Synonyms["@HATE"].Add ("HATE");
            this.Synonyms["@HATE"].Add ("DETEST");
            this.Synonyms["@HATE"].Add ("DESPISE");
            this.Synonyms["@HATE"].Add ("DISLIKE");
            this.Synonyms["@HATE"].Add ("LOATHE");
            this.Synonyms["@HATE"].Add ("ABHOR");
            this.Synonyms["@HATE"].Add ("RESENT");
            this.Synonyms["@HATE"].Add ("REJECT");
            this.Synonyms["@HATE"].Add ("SPURN");
        }

        /// <summary>
        /// Checks if the input implies the end of the conversation.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        /// <see langword="true"/> if the input implies the end of the conversation, otherwise
        /// <see langword="false"/>.
        /// </returns>
        private static bool DoesInputImplyEndOfConversation
            (string input)
        {
            return (input.ToUpper() == "BYE") ||
                    (input.ToUpper() == "GOODBYE") ||
                    (input.ToUpper() == "QUIT");
        }

        /// <summary>
        /// Gets the goodbye response.
        /// </summary>
        /// <returns>
        /// The goodbye response.
        /// </returns>
        private static string GetGoodByeResponse()
        {
            return Eliza.GoodbyeMessage;
        }

        /// <summary>
        /// Finds the matching pattern for the user's input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>The pattern or <see langword="null"/> if none was found.</returns>
        private Pattern FindMatchingPatternForInput
            (string input)
        {
            // Pre-transform some words in the user's input
            input = StringTransformer.PreTransform(input);

            // Find the highest ranked pattern that matches the user's input
            Pattern highestRankedMatchingPattern = null;
            foreach(Pattern p in this._patterns) {
                if (p.MatchesInput(input)) {
                    this._logger.Info(string.Format("FindMatchingPatternForInput: Matched {0} ({1})...",
                                                    p.GetType().Name, p.Rank));
                    if ((highestRankedMatchingPattern == null) || (p.Rank > highestRankedMatchingPattern.Rank)) {
                        highestRankedMatchingPattern = p;
                    }
                }
            }

            // Return the highest ranked matching pattern (if any)
            if (highestRankedMatchingPattern == null) {
                this._logger.Info("FindMatchingPatternForInput: NO PATTERN SELECTED");
            }
            else {
                this._logger.Info(string.Format("FindMatchingPatternForInput: Selected {0} ({1})...",
                                                highestRankedMatchingPattern.GetType().Name,
                                                highestRankedMatchingPattern.Rank));
            }
            return highestRankedMatchingPattern;
        }

        #endregion

        #region Fields

        /// <summary>
        /// The logger.
        /// </summary>
        private ILogger _logger;

        /// <summary>
        /// The patterns that Eliza understands.
        /// </summary>
        private List<Pattern> _patterns;

        /// <summary>
        /// The text spoken by Eliza when the conversation has ended.
        /// </summary>
        private const string GoodbyeMessage = "GOODBYE!  IT WAS NICE TALKING WITH YOU.";

        /// <summary>
        /// The text spoken by Eliza when no input has been specified.
        /// </summary>
        private const string EmptyInputMessage = "PLEASE SAY SOMETHING.";

        #endregion
    }
}
