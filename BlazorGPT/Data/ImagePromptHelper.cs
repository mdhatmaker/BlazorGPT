using System;
using Azure.AI.OpenAI;
using BlazorGPT.Models;

namespace BlazorGPT.Data;


public class ImagePromptHelper
{

    public static List<ImagePromptModel> GetImagePromptList()
    {
        var list = new List<ImagePromptModel>();

        list.Add(new ImagePromptModel("Avocado therapist", "illustration of an avocado sitting in a therapist's chair, saying 'I just feel so empty inside' with a pit-sized hole in its center. The therapist, a spoon, scribbles notes."));
        list.Add(new ImagePromptModel("Basketball player nebula", "An expressive oil painting of a basketball player dunking, depicted as an explosion of a nebula."));

        list.Add(new ImagePromptModel("1. Dystopian Industrial Cityscape", "Realistic painting of a dystopian industrial city with towering factories, pollution-filled air, and a gloomy sky."));
        list.Add(new ImagePromptModel("2. Victorian Masquerade", "Victorian-era painting of a masquerade ball with elaborate costumes, contrasting colors, and soft lighting."));
        list.Add(new ImagePromptModel("3. The Enchanted Forest", "Whimsical painting of an enchanted forest with mythical creatures, vibrant colors, and intricate details."));
        list.Add(new ImagePromptModel("4. Reflections in the Rain", "Cityscape painting during a rainy day, focusing on reflections in puddles with a mix of soft and harsh brush strokes."));
        list.Add(new ImagePromptModel("5. Stellar Dreams", "Surreal painting of a child dreaming about floating among stars, using soft, dreamy colors and elements of fantasy."));
        list.Add(new ImagePromptModel("6. The Majestic Polar Wilderness", "Arctic landscape painting with glaciers, polar bears, and the Northern Lights, using different shades of blue and green."));
        list.Add(new ImagePromptModel("7. The Mechanical Mind", "Steampunk-inspired painting representing the human mind as a complex mechanism, with intricate details and metallic colors."));
        list.Add(new ImagePromptModel("8. Ballet in the Moonlight", "Impressionistic painting of a ballet dancer performing under the moonlight, using soft shades of blue and silver."));
        list.Add(new ImagePromptModel("9. A Feast of Shadows", "Eerie painting of a feast in a dimly lit room, using shadows and low-light techniques."));
        list.Add(new ImagePromptModel("10. Clash of Elements", "Dramatic painting of a volcanic eruption near a body of water, using bold, contrasting colors."));
        list.Add(new ImagePromptModel("1. Ethereal Morning Mist", "Early morning photography of a landscape shrouded in mist, with diffused light and long shadows."));
        list.Add(new ImagePromptModel("2. Urban Jungle Gym", "Action photography of a parkour athlete jumping between urban structures, using a fast shutter speed."));
        list.Add(new ImagePromptModel("3. Nostalgic Vinyl Session", "Lifestyle photography of someone listening to vinyl records, using warm tones to evoke nostalgia."));
        list.Add(new ImagePromptModel("4. Majestic Mountain Peaks", "Landscape photography of snow-covered mountain peaks at sunrise, using natural light."));
        list.Add(new ImagePromptModel("5. Neon Nights", "Night photography of a neon-lit city street, using long exposure to capture motion."));
        list.Add(new ImagePromptModel("6. Pet’s Eye View", "Creative photography from the perspective of a pet, focusing on their interactions with the surroundings."));
        list.Add(new ImagePromptModel("7. The Coffee Shop Corner", "Interior photography of a cozy corner in a coffee shop, using natural light."));
        list.Add(new ImagePromptModel("8. Silent Snowfall", "Tranquil photography of a park during a gentle snowfall, using a slow shutter speed to blur the snowflakes."));
        list.Add(new ImagePromptModel("9. Golden Hour Portraits", "Portrait photography during the golden hour, using the soft, warm light to highlight the subject."));
        list.Add(new ImagePromptModel("10. Ephemeral Street Art", "Documentary photography of vibrant street art, using color and composition to convey the artwork’s energy."));
        list.Add(new ImagePromptModel("1. A Shattered Dimension", "Digital illustration of a dimension breaking apart, using vivid colors and fractured elements."));
        list.Add(new ImagePromptModel("2. Neon Samurai City", "Cyberpunk digital art of a neon-lit city with a samurai figure, highlighting the contrast between traditional and futuristic."));
        list.Add(new ImagePromptModel("3. Alien Flora", "Digital art of alien flora using a vibrant color palette and unusual shapes."));
        list.Add(new ImagePromptModel("4. Frozen Moment in a Dance", "Digital illustration of a ballet dancer in a graceful leap, blending realistic and abstract elements."));
        list.Add(new ImagePromptModel("5. The Steampunk Explorer", "Steampunk digital art of an explorer with their airship, using rich textures and detailed elements."));
        list.Add(new ImagePromptModel("6. The Lighthouse in the Storm", "Digital painting of a lighthouse amidst a violent storm, using contrasting light and dark colors."));
        list.Add(new ImagePromptModel("7. A Glimpse into the Future", "Futuristic digital art of a cityscape with drones, skyscrapers, and hover cars."));
        list.Add(new ImagePromptModel("8. Spirit Animal Totems", "Series of digital illustrations of spirit animals, using symbolism and cultural references."));
        list.Add(new ImagePromptModel("9. The Dream Weaver", "Digital illustration of a character weaving dreams in a surreal environment, using soft colors."));
        list.Add(new ImagePromptModel("10. Digital Odyssey", "Digital space odyssey with futuristic spacecraft and distant galaxies, using vibrant colors."));

        list.Add(new ImagePromptModel("gundam", "gundam, amoled wallpaper, mystical"));
        list.Add(new ImagePromptModel("wolf", "wolf in sheeps clothing, AMOLED wallpaper, avatar, digital art"));
        list.Add(new ImagePromptModel("gundam2", "gundam, amoled wallpaper, mystical"));
        list.Add(new ImagePromptModel("Dragon", "Dragon made of fire, AMOLED wallpaper"));
        list.Add(new ImagePromptModel("Dragon2", "Dragon made of fire, AMOLED wallpaper, logo mascot"));
        list.Add(new ImagePromptModel("gundam3", "gundam, amoled wallpaper, mystical"));
        list.Add(new ImagePromptModel("Dragon3", "Dragon made of fire, AMOLED wallpaper"));
        list.Add(new ImagePromptModel("Monsters", "Monsters, AMOLED wallpaper, digital art"));
        list.Add(new ImagePromptModel("Blueprint", "Blueprint of cartoon character, Cally3D, 3D, schematic, digital art, inner glow, AMOLED wallpaper"));
        list.Add(new ImagePromptModel("Fox", "Fox, kaleidoscope, AMOLED wallpaper"));
        list.Add(new ImagePromptModel("gundam4", "gundam, amoled wallpaper, mystical"));
        list.Add(new ImagePromptModel("wolf2", "wolf in sheeps clothing, AMOLED wallpaper, avatar, digital art"));
        list.Add(new ImagePromptModel("Golden", "Golden retriever, AMOLED wallpaper, op art"));
        list.Add(new ImagePromptModel("gundam5", "gundam, amoled wallpaper, mystical"));
        list.Add(new ImagePromptModel("Golden2", "Golden retriever, AMOLED wallpaper, op art"));
        list.Add(new ImagePromptModel("Golden3", "Golden retriever, AMOLED wallpaper, digital art"));
        list.Add(new ImagePromptModel("wolf3", "wolf in sheeps clothing, AMOLED wallpaper, avatar, op art, digital art"));
        list.Add(new ImagePromptModel("gundam6", "gundam, colorful splash, abstract, amoled wallpaper"));
        list.Add(new ImagePromptModel("Underwater", "Underwater Monsters, AMOLED wallpaper"));
        list.Add(new ImagePromptModel("Fox2", "Fox, kaleidoscope, AMOLED wallpaper"));
        list.Add(new ImagePromptModel("gundam7", "gundam, amoled wallpaper"));
        list.Add(new ImagePromptModel("Dragon4", "Dragon made of fire, AMOLED wallpaper"));
        list.Add(new ImagePromptModel("Golden4", "Golden retriever, AMOLED wallpaper, digital art"));
        list.Add(new ImagePromptModel("Dragon5", "Dragon made of fire, AMOLED wallpaper, logo mascot"));
        list.Add(new ImagePromptModel("Monsters2", "Monsters, AMOLED wallpaper, digital art"));
        list.Add(new ImagePromptModel("gundam8", "gundam vs voltron, amoled wallpaper"));
        list.Add(new ImagePromptModel("gundam9", "gundam, amoled wallpaper, mystical"));
        list.Add(new ImagePromptModel("Dragon6", "Dragon made of fire, AMOLED wallpaper, logo mascot"));


        return list;
    }


}

