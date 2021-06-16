#include "App.xaml.h"

//C# TO C++ CONVERTER WARNING: The following constructor is declared outside of its associated class:
//ORIGINAL LINE: public App()
public <missing_class_definition>::App()
{
	AppDomain::CurrentDomain->AssemblyResolve += new ResolveEventHandler(this, &CurrentDomain_AssemblyResolve);
}

private System::Reflection::Assembly *<missing_class_definition>::CurrentDomain_AssemblyResolve(void *sender, ResolveEventArgs *args)
{
//C# TO C++ CONVERTER TODO TASK: There is no direct native C++ equivalent to this .NET String method:
	std::wstring dllName = args->Name->Contains(L',') ? args->Name->substr(0, args->Name->find(L',')) : args->Name->Replace(L".dll",L"");

//C# TO C++ CONVERTER TODO TASK: There is no direct native C++ equivalent to this .NET String method:
	dllName = dllName.Replace(L".", L"_");

//C# TO C++ CONVERTER TODO TASK: There is no direct native C++ equivalent to this .NET String method:
	if (dllName.EndsWith(L"_resources"))
	{
		return nullptr;
	}

	System::Resources::ResourceManager *rm = new System::Resources::ResourceManager(GetType()->Namespace + std::wstring(L".Properties.Resources"), System::Reflection::Assembly::GetExecutingAssembly());

//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: byte[] bytes = (byte[])rm.GetObject(dllName);
	unsigned char *bytes = static_cast<unsigned char[]>(rm->GetObject(dllName));

	return System::Reflection::Assembly::Load(bytes);
}
