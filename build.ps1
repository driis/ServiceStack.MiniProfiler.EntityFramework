if ( -not (test-path "out")) {
	mkdir out
}
MSBuild /p:Configuration=Release
nuget pack  ServiceStack.MiniProfiler.EntityFramework.nuspec -OutputDirectory out