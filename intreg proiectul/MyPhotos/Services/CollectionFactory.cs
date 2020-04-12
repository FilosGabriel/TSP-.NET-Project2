using System;
using System.Collections.Generic;
using ModelAPI;

namespace MyPhotos.Services
{
    public class CollectionFactory
    {
        public static List<Media> createMedias()
        {
            var tags = createTags();
            var persons = createPersons();
            return new List<Media>()
            {
                SimpleFactory.CreateMedia("name1", "C:/Users/filos/OneDrive/Imagini/590526.jpg", "image", DateTime.Now,
                    "description", persons, tags),
            };
        }

        public static List<Tag> createTags()
        {
            return new List<Tag>()
            {
                new Tag()
                {
                    Name = "location"
                },
                new Tag()
                {
                    Name = "location"
                },
                new Tag()
                {
                    Name = "location"
                }
            };
        }

        public static List<People> createPersons()
        {
            return new List<People>()
            {
                new People()
                {
                    Name = "Alex Vla2"
                },
                new People()
                {
                    Name = "Alex Vl3"
                },
                new People()
                {
                    Name = "Alex Vl4"
                },
                new People()
                {
                    Name = "Alex Vl5"
                }
            };
        }
    }
}