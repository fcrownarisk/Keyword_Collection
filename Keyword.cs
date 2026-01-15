    /* ============================================
       COMPLETE LIST OF C# KEYWORDS
       ============================================ */
    /*
    C# Keywords by Category:
    
    ACCESS MODIFIERS:
    public, private, protected, internal, protected internal, private protected
    
    CLASS & STRUCT:
    class, struct, interface, enum, delegate, event, record (C# 9+)
    
    INHERITANCE:
    : (inheritance), base, new, virtual, override, abstract, sealed
    
    TYPE MODIFIERS:
    static, readonly, const, volatile, unsafe, fixed, stackalloc
    ref, out, in, params, async, await, yield, partial
    
    MEMBER DEFINITION:
    get, set, add, remove, value, operator, explicit, implicit, extern
    
    CONTROL FLOW:
    if, else, switch, case, default, for, foreach, in, while, do, break, continue, goto, return
    
    EXCEPTION HANDLING:
    try, catch, finally, throw, when (C# 6+)
    
    NAMESPACE & USING:
    namespace, using, alias (using alias =)
    
    TYPE OPERATORS:
    is, as, sizeof, typeof, nameof (C# 6+), default
    
    GENERICS:
    where, <T>
    
    NULL HANDLING:
    ?? (null-coalescing), ?. (null-conditional), ?[] (null-conditional index)
    ??= (null-coalescing assignment C# 8+), ? (nullable C# 8+), ! (null-forgiving C# 8+)
    
    PATTERN MATCHING (C# 7+):
    is (with patterns), switch (expression), var (in patterns)
    
    RANGES & INDICES (C# 8+):
    .. (range), ^ (index from end)
    
    ASYNC/ITERATORS:
    async, await, yield return, yield break, IAsyncEnumerable<T> (C# 8+)
    
    MISCELLANEOUS:
    lock, checked, unchecked, void, var, dynamic, object, string, bool, byte, sbyte, char,
    decimal, double, float, int, uint, long, ulong, short, ushort, nint, nuint (C# 9+)
    
    CONTEXTUAL KEYWORDS:
    add, alias, ascending, async, await, by, descending, dynamic, equals, from, get, global,
    group, into, join, let, nameof, notnull (C# 8+), on, orderby, partial, remove, select,
    set, unmanaged (C# 7.3+), value, var, when, where, yield
    
    RESERVED BUT NOT USED:
    __arglist, __makeref, __reftype, __refvalue
    
    C# 10+ ADDITIONS:
    file (access modifier), global using, record struct, with expressions enhancements
    */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KeywordsComparison
{
    public partial class MainForm : Form
    {
        private TabControl tabControl;
        private DataGridView cppGrid;
        private DataGridView csGrid;
        private TextBox searchBox;
        
        public MainForm()
        {
            InitializeComponent();
            SetupUI();
            LoadData();
        }
        
        private void SetupUI()
        {
            this.Text = "C++ 和 C# 关键字对比";
            this.Size = new Size(1000, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            
            // 搜索框
            searchBox = new TextBox
            {
                PlaceholderText = "搜索关键字...",
                Location = new Point(10, 10),
                Size = new Size(200, 20)
            };
            searchBox.TextChanged += SearchBox_TextChanged;
            this.Controls.Add(searchBox);
            
            // 标签控件
            tabControl = new TabControl
            {
                Location = new Point(10, 40),
                Size = new Size(970, 520)
            };
            
            // C++ 标签页
            TabPage cppPage = new TabPage("C++ 关键字");
            cppGrid = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                RowHeadersVisible = false
            };
            cppPage.Controls.Add(cppGrid);
            
            // C# 标签页
            TabPage csPage = new TabPage("C# 关键字");
            csGrid = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                RowHeadersVisible = false
            };
            csPage.Controls.Add(csGrid);
            
            tabControl.TabPages.Add(cppPage);
            tabControl.TabPages.Add(csPage);
            
            this.Controls.Add(tabControl);
        }
        
        private void LoadData()
        {
            // C++ 关键字数据
            var cppKeywords = new List<KeywordInfo>
            {
                new KeywordInfo("alignas", "指定类型或对象的对齐要求"),
                new KeywordInfo("alignof", "查询类型的对齐要求"),
                new KeywordInfo("and", "逻辑与运算符的替代表示"),
                new KeywordInfo("and_eq", "按位与赋值运算符的替代表示"),
                new KeywordInfo("asm", "用于嵌入汇编代码"),
                new KeywordInfo("auto", "用于类型推导，声明变量时根据初始化表达式自动推导类型"),
                new KeywordInfo("bitand", "按位与运算符的替代表示"),
                new KeywordInfo("bitor", "按位或运算符的替代表示"),
                new KeywordInfo("bool", "布尔类型"),
                new KeywordInfo("break", "跳出循环或switch语句"),
                new KeywordInfo("case", "switch语句中的一个分支"),
                new KeywordInfo("catch", "异常处理，捕获异常"),
                new KeywordInfo("char", "字符类型"),
                new KeywordInfo("class", "声明一个类"),
                new KeywordInfo("compl", "按位取反运算符的替代表示"),
                new KeywordInfo("const", "定义常量，或指定函数不修改对象"),
                new KeywordInfo("constexpr", "声明常量表达式，在编译时求值"),
                new KeywordInfo("const_cast", "用于修改类型的const或volatile属性"),
                new KeywordInfo("continue", "跳过当前循环的剩余代码，开始下一次循环"),
                new KeywordInfo("decltype", "查询表达式的类型"),
                new KeywordInfo("default", "switch语句中的默认分支，或显式默认生成的特殊成员函数"),
                new KeywordInfo("delete", "释放动态分配的内存，或禁止函数的使用"),
                new KeywordInfo("do", "循环语句，至少执行一次循环体"),
                new KeywordInfo("double", "双精度浮点类型"),
                new KeywordInfo("dynamic_cast", "在继承层次结构中进行安全的向下转换"),
                new KeywordInfo("else", "if语句的备用分支"),
                new KeywordInfo("enum", "声明枚举类型"),
                new KeywordInfo("explicit", "禁止构造函数或转换函数的隐式转换"),
                new KeywordInfo("export", "用于模板声明，现在很少使用"),
                new KeywordInfo("extern", "声明变量或函数在其他地方定义"),
                new KeywordInfo("false", "布尔类型的假值"),
                new KeywordInfo("float", "单精度浮点类型"),
                new KeywordInfo("for", "循环语句"),
                new KeywordInfo("friend", "声明友元函数或类"),
                new KeywordInfo("goto", "无条件跳转语句"),
                new KeywordInfo("if", "条件语句"),
                new KeywordInfo("inline", "建议编译器将函数内联展开"),
                new KeywordInfo("int", "整型"),
                new KeywordInfo("long", "长整型或长双精度浮点型"),
                new KeywordInfo("mutable", "允许在const成员函数中修改的类成员"),
                new KeywordInfo("namespace", "声明命名空间"),
                new KeywordInfo("new", "动态分配内存"),
                new KeywordInfo("not", "逻辑非运算符的替代表示"),
                new KeywordInfo("not_eq", "不等于运算符的替代表示"),
                new KeywordInfo("nullptr", "空指针常量"),
                new KeywordInfo("operator", "重载运算符"),
                new KeywordInfo("or", "逻辑或运算符的替代表示"),
                new KeywordInfo("or_eq", "按位或赋值运算符的替代表示"),
                new KeywordInfo("private", "声明类成员的私有访问权限"),
                new KeywordInfo("protected", "声明类成员的保护访问权限"),
                new KeywordInfo("public", "声明类成员的公共访问权限"),
                new KeywordInfo("register", "建议编译器将变量存储在寄存器中（C++17弃用）"),
                new KeywordInfo("reinterpret_cast", "用于低级的重新解释类型转换"),
                new KeywordInfo("return", "从函数返回"),
                new KeywordInfo("short", "短整型"),
                new KeywordInfo("signed", "有符号整型"),
                new KeywordInfo("sizeof", "查询类型或对象的大小"),
                new KeywordInfo("static", "静态存储期或内部链接"),
                new KeywordInfo("static_assert", "编译时断言"),
                new KeywordInfo("static_cast", "用于非多态类型转换"),
                new KeywordInfo("struct", "声明结构体"),
                new KeywordInfo("switch", "多路选择语句"),
                new KeywordInfo("template", "声明模板"),
                new KeywordInfo("this", "指向当前对象的指针"),
                new KeywordInfo("throw", "抛出异常"),
                new KeywordInfo("true", "布尔类型的真值"),
                new KeywordInfo("try", "异常处理，尝试执行可能抛出异常的代码块"),
                new KeywordInfo("typedef", "定义类型别名"),
                new KeywordInfo("typeid", "查询类型信息"),
                new KeywordInfo("typename", "声明模板中的类型名，或用于替代class声明模板参数"),
                new KeywordInfo("union", "声明联合体"),
                new KeywordInfo("unsigned", "无符号整型"),
                new KeywordInfo("using", "引入命名空间成员或定义类型别名"),
                new KeywordInfo("virtual", "声明虚函数"),
                new KeywordInfo("void", "无类型"),
                new KeywordInfo("volatile", "指定对象可能被意外修改，禁止优化"),
                new KeywordInfo("wchar_t", "宽字符类型"),
                new KeywordInfo("while", "循环语句"),
                new KeywordInfo("xor", "按位异或运算符的替代表示"),
                new KeywordInfo("xor_eq", "按位异或赋值运算符的替代表示")
            };
            
            // C# 关键字数据
            var csKeywords = new List<KeywordInfo>
            {
                new KeywordInfo("abstract", "声明抽象类或抽象方法"),
                new KeywordInfo("as", "用于类型转换，如果转换失败则返回null"),
                new KeywordInfo("base", "用于从派生类中访问基类的成员"),
                new KeywordInfo("bool", "布尔类型"),
                new KeywordInfo("break", "跳出循环或switch语句"),
                new KeywordInfo("byte", "8位无符号整数"),
                new KeywordInfo("case", "switch语句中的一个分支"),
                new KeywordInfo("catch", "异常处理，捕获异常"),
                new KeywordInfo("char", "字符类型"),
                new KeywordInfo("checked", "检查算术运算是否溢出"),
                new KeywordInfo("class", "声明一个类"),
                new KeywordInfo("const", "定义常量"),
                new KeywordInfo("continue", "跳过当前循环的剩余代码，开始下一次循环"),
                new KeywordInfo("decimal", "高精度十进制浮点类型"),
                new KeywordInfo("default", "switch语句中的默认分支，或指定泛型参数的默认值"),
                new KeywordInfo("delegate", "声明委托类型"),
                new KeywordInfo("do", "循环语句，至少执行一次循环体"),
                new KeywordInfo("double", "双精度浮点类型"),
                new KeywordInfo("else", "if语句的备用分支"),
                new KeywordInfo("enum", "声明枚举类型"),
                new KeywordInfo("event", "声明事件"),
                new KeywordInfo("explicit", "声明显式类型转换运算符"),
                new KeywordInfo("extern", "声明外部实现的方法"),
                new KeywordInfo("false", "布尔类型的假值"),
                new KeywordInfo("finally", "异常处理，无论是否发生异常都会执行的代码块"),
                new KeywordInfo("fixed", "防止垃圾回收器移动变量，用于不安全代码"),
                new KeywordInfo("float", "单精度浮点类型"),
                new KeywordInfo("for", "循环语句"),
                new KeywordInfo("foreach", "遍历集合中的每个元素"),
                new KeywordInfo("goto", "无条件跳转语句"),
                new KeywordInfo("if", "条件语句"),
                new KeywordInfo("implicit", "声明隐式类型转换运算符"),
                new KeywordInfo("in", "用于泛型接口和委托中的逆变，或foreach循环中"),
                new KeywordInfo("int", "整型"),
                new KeywordInfo("interface", "声明接口"),
                new KeywordInfo("internal", "声明内部访问权限，只能在当前程序集中访问"),
                new KeywordInfo("is", "检查对象是否与给定类型兼容"),
                new KeywordInfo("lock", "确保代码块不被多个线程同时执行"),
                new KeywordInfo("long", "长整型"),
                new KeywordInfo("namespace", "声明命名空间"),
                new KeywordInfo("new", "创建对象实例，或隐藏基类成员"),
                new KeywordInfo("null", "空引用"),
                new KeywordInfo("object", "所有类型的基类"),
                new KeywordInfo("operator", "重载运算符"),
                new KeywordInfo("out", "用于参数修饰符，表示输出参数，或泛型接口和委托中的协变"),
                new KeywordInfo("override", "重写基类的虚方法或抽象方法"),
                new KeywordInfo("params", "允许方法使用可变数量的参数"),
                new KeywordInfo("private", "声明私有访问权限"),
                new KeywordInfo("protected", "声明保护访问权限"),
                new KeywordInfo("public", "声明公共访问权限"),
                new KeywordInfo("readonly", "声明只读字段"),
                new KeywordInfo("ref", "用于参数修饰符，表示按引用传递"),
                new KeywordInfo("return", "从函数返回"),
                new KeywordInfo("sbyte", "8位有符号整数"),
                new KeywordInfo("sealed", "防止类被继承，或防止方法被重写"),
                new KeywordInfo("short", "短整型"),
                new KeywordInfo("sizeof", "获取值类型的大小（字节数）"),
                new KeywordInfo("stackalloc", "在不安全代码中分配栈内存"),
                new KeywordInfo("static", "声明静态成员"),
                new KeywordInfo("string", "字符串类型"),
                new KeywordInfo("struct", "声明结构体"),
                new KeywordInfo("switch", "多路选择语句"),
                new KeywordInfo("this", "指向当前对象的引用"),
                new KeywordInfo("throw", "抛出异常"),
                new KeywordInfo("true", "布尔类型的真值"),
                new KeywordInfo("try", "异常处理，尝试执行可能抛出异常的代码块"),
                new KeywordInfo("typeof", "获取类型的System.Type对象"),
                new KeywordInfo("uint", "无符号整型"),
                new KeywordInfo("ulong", "无符号长整型"),
                new KeywordInfo("unchecked", "不检查算术运算溢出"),
                new KeywordInfo("unsafe", "声明不安全的代码上下文"),
                new KeywordInfo("ushort", "无符号短整型"),
                new KeywordInfo("using", "引入命名空间，或定义资源范围（确保资源被释放）"),
                new KeywordInfo("virtual", "声明虚方法"),
                new KeywordInfo("void", "指定方法不返回值"),
                new KeywordInfo("volatile", "指定字段可能被多个线程同时访问，禁止优化"),
                new KeywordInfo("while", "循环语句")
            };
            
            // 配置DataGridView
            ConfigureGrid(cppGrid, cppKeywords);
            ConfigureGrid(csGrid, csKeywords);
        }
        
        private void ConfigureGrid(DataGridView grid, List<KeywordInfo> keywords)
        {
            grid.Columns.Clear();
            
            DataGridViewTextBoxColumn keywordColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "关键字",
                Name = "Keyword",
                Width = 120
            };
            
            DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "描述",
                Name = "Description",
                Width = 500
            };
            
            grid.Columns.Add(keywordColumn);
            grid.Columns.Add(descriptionColumn);
            
            foreach (var keyword in keywords)
            {
                grid.Rows.Add(keyword.Name, keyword.Description);
            }
            
            // 设置样式
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.None;
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            grid.DefaultCellStyle.Font = new Font("Arial", 9);
            grid.RowHeadersVisible = false;
            grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchBox.Text.Trim().ToLower();
            
            FilterGrid(cppGrid, searchText);
            FilterGrid(csGrid, searchText);
        }
        
        private void FilterGrid(DataGridView grid, string searchText)
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow) continue;
                
                string keyword = row.Cells["Keyword"].Value?.ToString() ?? "";
                string description = row.Cells["Description"].Value?.ToString() ?? "";
                
                if (keyword.ToLower().Contains(searchText) || 
                    description.ToLower().Contains(searchText))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }
    }
    
    public class KeywordInfo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        
        public KeywordInfo(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
    
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

}
