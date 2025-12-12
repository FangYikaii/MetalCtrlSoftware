using MetalizationSystem.WorkFlows.Recipe;
using System;
using System.IO;
using System.Xml.Serialization;

namespace MetalizationSystem.WorkFlows.Recipe
{
    /// <summary>
    /// 配方管理类，处理内部配方、外部配方及其相关操作
    /// </summary>
    public class RecipeManager
    {
        private Recipe _recipe;
        private int _currentIndex;

        public int CurrentExternalIndex
        {
            get { return _currentIndex; }
            set
            {
                if (value < 0 || value >= 6)
                    throw new IndexOutOfRangeException("Index must be between 0 and 6");
                _currentIndex = value;
            }
        }

        public bool IsInternalActive
        {
            get { return _isInternalActive; }
        }

        public RecipeManager()
        {
            _recipe = new Recipe();
            _currentIndex = 0;
            _isInternalActive = true;
        }

        /// <summary>
        /// 读取内部配方
        /// </summary>
   

        /// <summary>
        /// 读取外部配方组（十组参数）
        /// </summary>
        public Recipe ReadRecipesFromAI()
        {
            _currentIndex = 0;
            return _recipe;
        }

     
        /// <summary>
        /// 获取当前激活的参数集（根据内部/外部状态）
        /// </summary>
        public ParameterSet GetActiveParameterSet()
        {
            if (_isInternalActive)
            {
                return _internalRecipe.Parameters;
            }
            else
            {
                return _recipe.GetParameterSet(_currentIndex);
            }
        }

        /// <summary>
        /// 保存配方到文件
        /// </summary>
        public void SaveInternalRecipeToFile(string filePath)
        {
            try
            {
                var data = new RecipeData
                {
                    Internal = _internalRecipe,
                    //External = _externalRecipe,
                    //CurrentIndex = _currentExternalIndex,
                    //IsInternalActive = _isInternalActive
                };

                XmlSerializer serializer = new XmlSerializer(typeof(RecipeData));
                using (TextWriter writer = new StreamWriter(filePath))
                {
                    serializer.Serialize(writer, data);
                }

                Console.WriteLine("Recipes saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving recipes: {ex.Message}");
            }
        }

        /// <summary>
        /// 从文件加载配方
        /// </summary>
        public void LoadInternalRecipeFromFile(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("File does not exist.");
                    return;
                }

                XmlSerializer serializer = new XmlSerializer(typeof(RecipeData));
                using (TextReader reader = new StreamReader(filePath))
                {
                    RecipeData data = (RecipeData)serializer.Deserialize(reader);
                    _internalRecipe = data.Internal;
                    //_externalRecipe = data.External;
                    //_currentExternalIndex = data.CurrentIndex;
                    //_isInternalActive = data.IsInternalActive;
                }
                Console.WriteLine("Recipes loaded successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading recipes: {ex.Message}");
            }
        }

        /// <summary>
        /// 显示当前状态
        /// </summary>
        public void DisplayCurrentStatus()
        {
            Console.WriteLine($"Current active recipe: {(IsInternalActive ? "Internal" : "External")}");
            if (!IsInternalActive)
            {
                Console.WriteLine($"Current external index: {CurrentExternalIndex}");
            }

            Console.WriteLine("Active parameters:");
            Console.WriteLine(GetActiveParameterSet().ToString());
        }

        /// <summary>
        /// 写入外部配方：配方、配方个数
        /// </summary>
        public void WriteExternalRecipe()
        {
            
            ;
        }
    }

    // 辅助类用于序列化
    [Serializable]
    public class RecipeData
    {
        public InternalRecipe Internal { get; set; }
        public Recipe External { get; set; }
        public int CurrentIndex { get; set; }
        public bool IsInternalActive { get; set; }
    }
}