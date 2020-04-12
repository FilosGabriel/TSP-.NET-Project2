using System;
using System.Collections.Generic;
using System.IO;
using ModelAPI;

namespace MyPhotos.Services
{
    internal class SimpleFactory
    {
        public static Media CreateMedia(string nameI, string pathI, string formatI, DateTime dateI, string descriptionI,
            List<People> people, List<Tag> tags)
        {
            return new Media()
            {
                MediaId = Guid.NewGuid(),
                Name = nameI,
                FullPath = pathI,
                Format = formatI,
                DateOfCreation = dateI,
                Description = descriptionI,
            };
        }

        public static Media CreateMediaFromPath(string path)
        {
            return new Media()
            {
                Name = Path.GetFileNameWithoutExtension(path),
                Format = Path.GetExtension(path),
                FullPath = Path.GetFullPath(path),
                DateOfCreation = File.GetCreationTime(path),
                Description = string.Empty
            };
        }


        public static Event CreateEvent(string eventInput)
        {
            return new Event()
            {
                EventId = Guid.NewGuid(),
                Name = eventInput
            };
        }

        public static Tag CreateTag(string s)
        {
            return new Tag()
            {
                TagId = Guid.NewGuid(),
                Name = s
            };
        }

        public static People createPerson(string nameI)
        {
            return new People()
            {
                PeopleId = Guid.NewGuid(),
                Name = nameI
            };
        }

        public static Place CreatePlace(string nameI)
        {
            return new Place()
            {
                PlaceId = Guid.NewGuid(),
                Name = nameI
            };
        }
    }
}