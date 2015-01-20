MONOXBUILD=/Library/Frameworks/Mono.framework/Commands/xbuild

all: Makefile ApiDefinition.cs StructsAndEnums.cs libFlurry_6.0.0.a
	$(MONOXBUILD) /p:Configuration=Release MonoTouch.FlurryAnalytics.csproj
	cp bin/Release/MonoTouch.FlurryAnalytics.dll MonoTouch.FlurryAnalytics.dll

clean:
	-rm -rf list ios *.dll *.zip *.mdb bin/ obj/