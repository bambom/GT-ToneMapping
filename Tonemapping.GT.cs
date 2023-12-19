using System;

namespace UnityEngine.Rendering.Universal
{
  


    /// <summary>
    /// A volume component that holds settings for the tonemapping effect.
    /// </summary>
    [Serializable, VolumeComponentMenuForRenderPipeline("Post-processing/Tonemapping", typeof(UniversalRenderPipeline))]
    //[URPHelpURL("post-processing-tonemapping")]
    public  sealed partial class Tonemapping : VolumeComponent, IPostProcessComponent
    {
        /// <summary>
        /// Use this to select a tonemapping algorithm to use for color grading.
        /// </summary>
        [Tooltip("Select a tonemapping algorithm to use for the color grading process.")]
        public TonemappingModeParameter mode = new TonemappingModeParameter(TonemappingMode.None);

        // -- HDR Output options --
        public FloatParameter MaximumBrightness = new FloatParameter(1);
        public FloatParameter Contrast = new FloatParameter(0.94f);
        public FloatParameter LinearSectionStart = new FloatParameter(0.3f);
        public FloatParameter LinearSectionLength = new FloatParameter(0.59f);
        public FloatParameter BlackTightness = new FloatParameter(1.45f);
        
        /// <inheritdoc/>
        public bool IsActive() => mode.value != TonemappingMode.None;

        /// <inheritdoc/>
        public bool IsTileCompatible() => true;
    }

}
