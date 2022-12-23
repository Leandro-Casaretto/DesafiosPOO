namespace Ucu.Poo.Defense
{
    public class Material
    {
        public string Name { get; set; }

        public MaterialType Type { get; set; }

        public Material(string name, MaterialType type)
        {
            this.Name = name;
            this.Type = type;
        }

        /// <summary>
        /// Para conocer si el material es peligroso o no, devolvemos el IsDangerous
        /// de MaterialType.
        /// </summary>
        
        public bool IsDangerous
        {
            get
            {
                return this.Type.IsDangerous;
            }
        }
    }
}