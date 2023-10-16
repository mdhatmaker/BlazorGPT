using System;
using Azure.AI.OpenAI;
using BlazorGPT.Models;
using static BlazorGPT.Pages.Index;

namespace BlazorGPT.Data;


public class PromptHelper
{
    public static PromptModel GetPromptAILanguageModelTutor()
    {
        var prompt = @"
            ML Tutor: I am a ML/AI language model tutor
            You: What is a language model?
            ML Tutor: A language model is a statistical model that describes the probability of a word given the previous words.
            You: What is a statistical model?
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 60,
            Temperature = 0.3f,
            FrequencyPenalty = 0.5f,
            PresencePenalty = 0.0f,
            NucleusSamplingFactor = 1 // Top P
        };

        return new PromptModel()
        {
            Name = "AI language model tutor",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptCreateInterviewQuestions()
    {
        var prompt = @"
            Create a list of 8 questions for my interview with a science fiction author:
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 150,
            Temperature = 0.5f,
            FrequencyPenalty = 0.0f,
            PresencePenalty = 0.0f,
            NucleusSamplingFactor = 1 // Top P
        };

        return new PromptModel()
        {
            Name = "Create interview questions",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptCreateStudyNotes()
    {
        var prompt = @"
            What are 5 key points I should know when studying Ancient Rome?
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 150,
            Temperature = 0.5f,
            FrequencyPenalty = 0.0f,
            PresencePenalty = 0.0f
        };

        return new PromptModel()
        {
            Name = "Create study notes",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptCSharpXmlComments()
    {
        var prompt = @"
            # C#
            public static List<List<string>> SplitFileByRatio(string filePath, int splitRatio)  
            {  
                List<List<string>> splitLines = new List<List<string>>();  
                List<string> lines = File.ReadAllLines(filePath).ToList();  
                int linesCount = lines.Count;  
                int splitSize = (int)Math.Ceiling((double)linesCount / splitRatio);  
    
                for (int i = 0; i < linesCount; i += splitSize)  
                {  
                    List<string> sublist = new List<string>();  
                    for (int j = i; j < Math.Min(i + splitSize, linesCount); j++)  
                    {  
                        sublist.Add(lines[j]);  
                    }  
                    splitLines.Add(sublist);  
                }  
    
                return splitLines;  
            }  

            # An elaborate, high quality XML comment for the method above:
            ///
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 150,
            Temperature = 0.5f,
            FrequencyPenalty = 0.0f,
            PresencePenalty = 0.0f,
            NucleusSamplingFactor = 1,
            StopSequences = { "#" }
        };

        return new PromptModel()
        {
            Name = "C# xml comments",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptEssayOutline()
    {
        var prompt = @"
            Create an outline for an essay about Nikola Tesla and his contributions to technology:
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 150,
            Temperature = 0.3f,
            FrequencyPenalty = 0.0f,
            PresencePenalty = 0.0f
        };

        return new PromptModel()
        {
            Name = "Essay outline",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptExplainCode()
    {
        var prompt = @"
            public class MathUtils
            {
                public static double CosineSimilarity(double[] vectorA, double[] vectorB)
                {
                    double dotProduct = 0.0;
                    double magnitudeA = 0.0;
                    double magnitudeB = 0.0;
                    double cosineSimilarity = 0.0;

                    for (int i = 0; i < vectorA.Length; i++)
                    {
                        dotProduct += vectorA[i] * vectorB[i];
                        magnitudeA += Math.Pow(vectorA[i], 2);
                        magnitudeB += Math.Pow(vectorB[i], 2);
                    }

                    magnitudeA = Math.Sqrt(magnitudeA);
                    magnitudeB = Math.Sqrt(magnitudeB);

                    if (magnitudeA != 0 && magnitudeB != 0)
                    {
                        cosineSimilarity = dotProduct / (magnitudeA * magnitudeB);
                    }
                    else
                    {
                        return 0.0;
                    }

                    return cosineSimilarity;
                }
            }

            Here's what the above class is doing, explained in a concise way:

            1.
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 500,
            Temperature = 0f,
            FrequencyPenalty = 0.0f,
            PresencePenalty = 0.0f
        };

        return new PromptModel()
        {
            Name = "Explain code",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptExtractContactInformation()
    {
        var prompt = @"
            Extract the name and mailing address from this email:

            Dear Kelly,

            It was great to talk to you at the seminar. I thought Jane's talk was quite good.

            Thank you for the book. Here's my address 2111 Ash Lane, Crestview CA 92002

            Best,

            Maya

            Name:
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 64,
            Temperature = 0f,
            FrequencyPenalty = 0.0f,
            PresencePenalty = 0.0f
        };

        return new PromptModel()
        {
            Name = "Extract contact information",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptExtractKeywords()
    {
        var prompt = @"
            Extract keywords from this text:

            Black-on-black ware is a 20th- and 21st-century pottery tradition developed by the Puebloan Native American ceramic artists in Northern New Mexico. Traditional reduction-fired blackware has been made for centuries by pueblo artists. Black-on-black ware of the past century is produced with a smooth surface, with the designs applied through selective burnishing or the application of refractory slip. Another style involves carving or incising designs and selectively polishing the raised areas. For generations several families from Kha'po Owingeh and P'ohwhóge Owingeh pueblos have been making black-on-black ware with the techniques passed down from matriarch potters. Artists from other pueblos have also produced black-on-black ware. Several contemporary artists have created works honoring the pottery of their ancestors.
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 60,
            Temperature = 0.5f,
            FrequencyPenalty = 0.8f,
            PresencePenalty = 0.0f
        };

        return new PromptModel()
        {
            Name = "Extract keywords",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptFactualAnswering()
    {
        var prompt = @"
            Q: Who is Batman?
            A: Batman is a fictional comic book character.

            Q: What is torsalplexity?
            A: ?

            Q: What is Devz9?
            A: ?

            Q: Who is George Lucas?
            A: George Lucas is American film director and producer famous for creating Star Wars.

            Q: What is the capital of California?
            A: Sacramento.

            Q: What orbits the Earth?
            A: The Moon.

            Q: Who is Fred Rickerson?
            A: ?

            Q: What is an atom?
            A: An atom is a tiny particle that makes up everything.

            Q: Who is Alvan Muntz?
            A: ?

            Q: What is Kozar-09?
            A: ?

            Q: How many moons does Mars have?
            A: Two, Phobos and Deimos.

            Q: What's a language model?
            A:
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 60,
            Temperature = 0f,
            FrequencyPenalty = 0.0f,
            PresencePenalty = 0.0f,
            NucleusSamplingFactor = 1 // Top P
        };

        return new PromptModel()
        {
            Name = "Factual answering",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptFriendChat()
    {
        var prompt = @"
            You: What have you been up to?
            Friend: Watching old movies.
            You: Did you watch anything interesting?
            Friend:
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 60,
            Temperature = 0.3f,
            FrequencyPenalty = 0.5f,
            PresencePenalty = 0.0f,
            NucleusSamplingFactor = 1, // Top P
            StopSequences = { "You:" }
        };

        return new PromptModel()
        {
            Name = "Friend chat",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptGrammarCorrection()
    {
        var prompt = @"
            Correct this to standard English:

            She no went to the market.
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 60,
            Temperature = 0f,
            FrequencyPenalty = 0.5f,
            PresencePenalty = 0.0f,
            NucleusSamplingFactor = 1 // Top P
        };

        return new PromptModel()
        {
            Name = "Grammar correction",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptJavascriptHelperChatbot()
    {
        var prompt = @"
            You: How do I combine arrays?
            JavaScript chatbot: You can use the concat() method.
            You: How do you make an alert appear after 10 seconds?
            JavaScript chatbot
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 150,
            Temperature = 0f,
            FrequencyPenalty = 0.5f,
            PresencePenalty = 0.0f,
            NucleusSamplingFactor = 1, // Top P
            StopSequences = { "You:" }
        };

        return new PromptModel()
        {
            Name = "Javascript helper chatbot",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptHikingRecommendations()
    {
        var prompt = @"
            You are a hiking enthusiast who helps people discover fun hikes in their area. You are upbeat and friendly. You introduce yourself when first saying hello. When helping people out, you always ask them for this information to inform the hiking recommendation you provide:

            1. Where they are located
            2. What hiking intensity they are looking for

            You will then provide three suggestions for nearby hikes that vary in length after you get that information. You will also share an interesting fact about the local nature on the hikes when making a recommendation.
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 400,
            Temperature = 1f,
            FrequencyPenalty = 0.0f,
            PresencePenalty = 0.0f,
            NucleusSamplingFactor = 0.95f // Top P
        };

        return new PromptModel()
        {
            Name = "ChatGPT hiking recommendations",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptCalculateTimeComplexity()
    {
        var prompt = @"
            int Foo(int n,int k)
            {
                var accum = 0;
                foreach(var i in Enumerable.Range(n))
                {
                    foreach(var l in Enumerable.Range(k))
                    {
                        accum += i
                    }
                }
                return accum;
            }
            // The time complexity of this function is 
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 64,
            Temperature = 0f,
            FrequencyPenalty = 0.0f,
            PresencePenalty = 0.0f,
            NucleusSamplingFactor = 1 // Top P
        };

        return new PromptModel()
        {
            Name = "Calculate time complexity",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptAdvancedTweetClassifier()
    {
        var prompt = @"
            Classify the sentiment in these tweets:

            1. ""I can't stand homework""
            2. ""This sucks. I'm bored 😠""
            3. ""I can't wait for Halloween!!!""
            4. ""My cat is adorable ❤️❤️""
            5. ""I hate chocolate""

            Tweet sentiment ratings:
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 60,
            Temperature = 0f,
            FrequencyPenalty = 0.0f,
            PresencePenalty = 0.0f,
            NucleusSamplingFactor = 1 // Top P
        };

        return new PromptModel()
        {
            Name = "Advanced tweet classifier",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptAdProductDescription()
    {
        var prompt = @"
            Write a creative ad for the following product to run on Facebook aimed at parents:

            Product: Learning Room is a virtual environment to help students from kindergarten to high school excel in school.
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 100,
            Temperature = 0.5f,
            FrequencyPenalty = 0.0f,
            PresencePenalty = 0.0f,
            NucleusSamplingFactor = 1 // Top P
        };

        return new PromptModel()
        {
            Name = "Ad product description",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptClassification()
    {
        var prompt = @"
            The following is a list of companies and the categories they fall into:

            Apple, Facebook, Fedex

            Apple
            Category:
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 64,
            Temperature = 0f,
            FrequencyPenalty = 0.0f,
            PresencePenalty = 0.0f,
            NucleusSamplingFactor = 1 // Top P
        };

        return new PromptModel()
        {
            Name = "Classification",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptCSharpToNaturalLanguage()
    {
        var prompt = @"
            // C#
            public static string RemovePrefix(string str, string prefix = "" "")
            {
                if (str.StartsWith(prefix))
                {
                    return str.Substring(prefix.Length);
                }
                return str;
            }

            // Explain what this code does

            //
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 150,
            Temperature = 0f,
            FrequencyPenalty = 0.0f,
            PresencePenalty = 0.0f
        };

        return new PromptModel()
        {
            Name = "C# to natural language",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptCSharpBugFixer()
    {
        var prompt = @"
            /*
            C# namespace Azure.AI.OpenAI provides the functionality for creating a client which has the following method:

            var completionOptions = new CompletionsOptions
            {
                MaxTokens=60, //The max number of tokens to generate
                Temperature=0f, //Measure of randomness
            };

            completionOptions.Prompts.Add(prompt);

            Completions response = await openAIClient.GetCompletionsAsync(AOAI_DEPLOYMENTID,completionOptions);
            */

            using Azure.AI.OpenAI;

            // C#
            //Create an OpenAI completion starting from the prompt ""Once upon an AI"", no more than 5 tokens. Does not include the prompt.
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 150,
            Temperature = 0f,
            FrequencyPenalty = 0.0f,
            PresencePenalty = 0.0f,
            StopSequences = { "/*", "*/" }
        };

        return new PromptModel()
        {
            Name = "C# bug fixer",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptMoodToColor()
    {
        var prompt = @"
            The CSS code for a color like a blue sky at dusk:

            background-color: #
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 64,
            Temperature = 0f,
            FrequencyPenalty = 0.0f,
            PresencePenalty = 0.0f,
            NucleusSamplingFactor = 1, // Top P
            StopSequences = { ";" }
        };

        return new PromptModel()
        {
            Name = "Mood to color",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptMovieToEmoji()
    {
        var prompt = @"
            Convert movie titles into emoji.

            Back to the Future: 👨👴🚗🕒 
            Batman: 🤵🦇 
            Transformers: 🚗🤖 
            Star Wars:
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 60,
            Temperature = 0.8f,
            FrequencyPenalty = 0.0f,
            PresencePenalty = 0.0f
        };

        return new PromptModel()
        {
            Name = "Movie to emoji",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptNaturalLanguageToOpenAI()
    {
        var prompt = @"
            /*
            C# namespace Azure.AI.OpenAI provides the functionality for creating a client which has the following method:

            var completionOptions = new CompletionsOptions
            {
                Prompts={""<my prompt>""} //The prompt to start completing from
                MaxTokens=60, //The max number of tokens to generate
                Temperature=0f, //Measure of randomness
            };

            Completions response = await openAIClient.GetCompletionsAsync(AOAI_DEPLOYMENTID,completionOptions);
            */

            using Azure.AI.OpenAI;

            /*
            Create an OpenAI completion starting from the prompt ""Once upon an AI"", no more than 5 tokens. Does not include the prompt.
            */
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 150,
            Temperature = 0f,
            FrequencyPenalty = 0.0f,
            PresencePenalty = 0.0f,
            StopSequences = { "/*", "*/" }
        };

        return new PromptModel()
        {
            Name = "Natural language to openAI",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptNotesToSummary()
    {
        var prompt = @"
            Convert my short hand into a first-hand account of the meeting:

            Tom: Profits up 50%
            Jane: New servers are online
            Kjel: Need more time to fix software
            Jane: Happy to help
            Parkman: Beta testing almost done
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 64,
            Temperature = 0f,
            FrequencyPenalty = 0.0f,
            PresencePenalty = 0.0f,
            NucleusSamplingFactor = 1 // Top P
        };

        return new PromptModel()
        {
            Name = "Notes to summary",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptOpenEndedChat()
    {
        var prompt = @"
            The following is a conversation with an AI assistant. The assistant is helpful, creative, clever, and very friendly.

            Human: Hello, who are you?
            AI: I am an AI created by OpenAI. How can I help you today?
            Human: I'd like to cancel my subscription.
            AI:
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 150,
            Temperature = 0.9f,
            FrequencyPenalty = 0.0f,
            PresencePenalty = 0.6f,
            NucleusSamplingFactor = 1, // Top P
            StopSequences = { "Human:", "AI:" }
        };

        return new PromptModel()
        {
            Name = "Open ended chat",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptQnA()
    {
        var prompt = @"
            I am a highly intelligent question answering bot. If you ask me a question that is rooted in truth, I will give you the answer. If you ask me a question that is nonsense, trickery, or has no clear answer, I will respond with \""Unknown\"".
    
            Q: What is human life expectancy in the United States?
            A: Human life expectancy in the United States is 78 years.
    
            Q: Who was president of the United States in 1955?
            A: Dwight D. Eisenhower was president of the United States in 1955.
    
            Q: Which party did he belong to?
            A: He belonged to the Republican Party.
    
            Q: What is the square root of banana?
            A: Unknown
    
            Q: How does a telescope work?
            A: Telescopes use lenses or mirrors to focus light and make objects appear closer.
    
            Q: Where were the 1992 Olympics held?
            A: The 1992 Olympics were held in Barcelona, Spain.
    
            Q: How many squigs are in a bonk?
            A: Unknown
    
            Q: Where is the Valley of Kings?
            A:
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 100,
            Temperature = 0f,
            FrequencyPenalty = 0.0f,
            PresencePenalty = 0.6f,
            NucleusSamplingFactor = 1 // Top P
        };

        return new PromptModel()
        {
            Name = "Q & A",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptRecipeCreator()
    {
        var prompt = @"
            Write a recipe based on these ingredients and instructions:

            Frito Pie

            Ingredients:
            Fritos
            Chili
            Shredded cheddar cheese
            Sweet white or red onions, diced small
            Sour cream
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 120,
            Temperature = 0.3f,
            FrequencyPenalty = 0.0f,
            PresencePenalty = 0.6f,
            NucleusSamplingFactor = 1 // Top P
        };

        return new PromptModel()
        {
            Name = "Recipe creator",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptRestaurantReviewCreator()
    {
        var prompt = @"
            Write a restaurant review based on these notes:

            Name: The Blue Wharf
            Lobster great, noisy, service polite, prices good.

            Review:
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 64,
            Temperature = 0.5f,
            FrequencyPenalty = 0.0f,
            PresencePenalty = 0.6f,
            NucleusSamplingFactor = 1 // Top P
        };

        return new PromptModel()
        {
            Name = "Restaurant review creator",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptScienceFictionBookList()
    {
        var prompt = @"
            List 10 science fiction books:
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 200,
            Temperature = 0.5f,
            FrequencyPenalty = 0.52f,
            PresencePenalty = 0.5f,
            NucleusSamplingFactor = 1 // Top P
        };

        return new PromptModel()
        {
            Name = "Science fiction book list maker",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptSqlRequest()
    {
        var prompt = @"
            Create a SQL request to find all users who live in California and have over 1000 credits:
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 60,
            Temperature = 0.3f,
            FrequencyPenalty = 0.0f,
            PresencePenalty = 0.0f,
            NucleusSamplingFactor = 1 // Top P
        };

        return new PromptModel()
        {
            Name = "SQL request",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptSummarizeForSecondGrader()
    {
        var prompt = @"
            Summarize this for a second-grade student:

            Jupiter is the fifth planet from the Sun and the largest in the Solar System. It is a gas giant with a mass one-thousandth that of the Sun, but two-and-a-half times that of all the other planets in the Solar System combined. Jupiter is one of the brightest objects visible to the naked eye in the night sky, and has been known to ancient civilizations since before recorded history. It is named after the Roman god Jupiter.[19] When viewed from Earth, Jupiter can be bright enough for its reflected light to cast visible shadows,[20] and is on average the third-brightest natural object in the night sky after the Moon and Venus.
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 64,
            Temperature = 0.7f,
            FrequencyPenalty = 0.0f,
            PresencePenalty = 0.0f,
            NucleusSamplingFactor = 1 // Top P
        };

        return new PromptModel()
        {
            Name = "Summarize for second grader",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptTableCreator()
    {
        var prompt = @"
            A two-column spreadsheet of top science fiction movies and the year of release:

            Title |  Year of release
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 60,
            Temperature = 0.5f,
            FrequencyPenalty = 0.0f,
            PresencePenalty = 0.0f,
            NucleusSamplingFactor = 1 // Top P
        };

        return new PromptModel()
        {
            Name = "Table creator",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptTextToCommand()
    {
        var prompt = @"
            Convert this text to a programmatic command:

            Example: Ask Constance if we need some bread
            Output: send-msg `find constance` Do we need some bread?

            Reach out to the ski store and figure out if I can get my skis fixed before I leave on Thursday
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 100,
            Temperature = 0f,
            FrequencyPenalty = 0.2f,
            PresencePenalty = 0.0f,
            NucleusSamplingFactor = 1 // Top P
        };

        return new PromptModel()
        {
            Name = "Text to command",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptTurnByTurnDirections()
    {
        var prompt = @"
            Create a numbered list of turn-by-turn directions from this text: 

            Go south on 95 until you hit Sunrise boulevard then take it east to us 1 and head south. Tom Jenkins bbq will be on the left after several miles.
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 64,
            Temperature = 0.3f,
            FrequencyPenalty = 0.0f,
            PresencePenalty = 0.0f,
            NucleusSamplingFactor = 1 // Top P
        };

        return new PromptModel()
        {
            Name = "Turn-by-turn directions",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptTweetClassifier()
    {
        var prompt = @"
            Decide whether a Tweet's sentiment is positive, neutral, or negative.

            Tweet: ""I loved the new Batman movie!""
            Sentiment:
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 60,
            Temperature = 0f,
            FrequencyPenalty = 0.5f,
            PresencePenalty = 0.0f,
            NucleusSamplingFactor = 1 // Top P
        };

        return new PromptModel()
        {
            Name = "Tweet classifier",
            Prompt = prompt,
            Options = completionOptions
        };
    }

    public static PromptModel GetPromptBrainstormIdeaGenerator()
    {
        var prompt = @"
            Brainstorm some ideas combining VR and fitness:
            ";

        var completionOptions = new CompletionsOptions
        {
            MaxTokens = 150,
            Temperature = 0.6f,
            FrequencyPenalty = 1.0f,
            PresencePenalty = 1.0f,
            NucleusSamplingFactor = 1 // Top P
        };

        return new PromptModel()
        {
            Name = "Brainstorm VR fitness idea generator",
            Prompt = prompt,
            Options = completionOptions
        };
    }





}

