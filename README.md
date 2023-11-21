# Compute-Workflow
Unity C# tool for comfortable dispatching ComputeShaders.

Using with costum compute shaders
1. Create Buffer classes inherited from RWBuffer and RWTexture.
2. Create Parametres classes inherited from Parametres.
3. Create ComputeConvoy class inherited from ReportableConvoy or ComputeConvoy with Buffer fields and Parametres.
4. Use your Convoy for opertaing ComputeShader.
