﻿using System.Reflection;

namespace Monofoxe.Engine.DesktopGL
{
	public class AlphaBlendEffectLoaderDesktopGl: AlphaBlendEffectLoader
	{
		protected override string _effectName => "Monofoxe.Engine.DesktopGL.AlphaBlend_gl.mgfxo";

		protected override Assembly _assembly => Assembly.GetAssembly(typeof(AlphaBlendEffectLoaderDesktopGl));

	}
}
