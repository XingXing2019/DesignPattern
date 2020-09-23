using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Chef
{
    public class DynamicProxy
    {
        public static void Run()
        {
            var assemblyName = new AssemblyName("ChefDynamicAssembly");
            var assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);

            var moduleBuilder = assemblyBuilder.DefineDynamicModule(assemblyName.Name + ".dll");
            var typeBuilder = moduleBuilder.DefineType("Command");

            var attributes = MethodAttributes.Public;

            var methodBuilder = typeBuilder.DefineMethod("Do", attributes, typeof(string), Type.EmptyTypes);

            var il = methodBuilder.GetILGenerator();

            var vegetables = il.DeclareLocal(typeof(string));
            il.Emit(OpCodes.Ldc_I4, 3);
            il.Emit(OpCodes.Newarr, typeof(string));
            il.Emit(OpCodes.Stloc, vegetables);

            il.Emit(OpCodes.Ldloc, vegetables);
            il.Emit(OpCodes.Ldc_I4, 0);
            il.Emit(OpCodes.Ldstr, "Potato");
            il.Emit(OpCodes.Stelem, typeof(string));

            il.Emit(OpCodes.Ldloc, vegetables);
            il.Emit(OpCodes.Ldc_I4, 1);
            il.Emit(OpCodes.Ldstr, "Tomato");
            il.Emit(OpCodes.Stelem, typeof(string));


            var cheif = il.DeclareLocal(typeof(IChef));
            il.Emit(OpCodes.Newobj, typeof(VegeChef).GetConstructor(Type.EmptyTypes)); 
            il.Emit(OpCodes.Stloc, cheif);

            var dish = il.DeclareLocal(typeof(string));
            il.Emit(OpCodes.Ldloc, cheif);
            il.Emit(OpCodes.Ldloc, vegetables);
            il.Emit(OpCodes.Callvirt, typeof(IChef).GetMethod("Cook"));
            il.Emit(OpCodes.Stloc, dish);

            il.Emit(OpCodes.Ldloc, dish);
            il.Emit(OpCodes.Ret);

            var dynamicType = typeBuilder.CreateType();
            var commander = Activator.CreateInstance(dynamicType);
            Console.WriteLine(dynamicType.GetMethod("Do").Invoke(commander, null).ToString());
            Console.ReadLine();
        }
    }
}