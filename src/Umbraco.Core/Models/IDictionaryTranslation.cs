using System.Runtime.Serialization;
using Umbraco.Core.Models.EntityBase;

namespace Umbraco.Core.Models
{
    public interface IDictionaryTranslation : IEntity
    {
        /// <summary>
        /// Gets or sets the <see cref="Language"/> for the translation
        /// </summary>
        [DataMember]
        ILanguage Language { get; set; }

        /// <summary>
        /// Gets or sets the translated text
        /// </summary>
        [DataMember]
        string Value { get; set; }
    }
}