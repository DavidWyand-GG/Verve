//-----------------------------------------------------------------------------
// Torque3D - postFXManager.gui.cs - Contains the code for the implementation 
//            of the gui controls used in postFXManager.gui.
//
//
// Copyright (C) Luma Arcade 2010
// Written By Sven Bergstrom | Luma Arcade
//-----------------------------------------------------------------------------

$PostFXManager::vebose = true;
function postVerbose(%string)
{
   if($PostFXManager::vebose == true)
   {
      echo(%string);
   }
}

function PostFXManager::onDialogPush( %this )
{
   //Apply the settings to the controls
   postVerbose("% - PostFX Manager - Loading GUI.");
   
   %this.settingsRefreshAll();
}

// :: Controls for the overall postFX manager dialog
function ppOptionsEnable::onAction(%this)
{
   //Disable / Enable all PostFX

   if(ppOptionsEnable.getValue())
   {
      %toEnable = true;
   }   
   else
   {
      %toEnable = false;
   }
   
   PostFXManager.settingsSetEnabled(%toEnable);
   
}

function PostFXManager::getEnableResultFromControl(%this, %control)
{
   %toEnable = -1;
   %bTest = %control.getValue();
   if(%bTest == 1)
   {
      %toEnable = true;
   }
   else
   {
      %toEnable = false;
   }
   
   return %toEnable;
}

function ppOptionsEnableSSAO::onAction(%this)
{
   %toEnable = PostFXManager.getEnableResultFromControl(%this);
   PostFXManager.settingsEffectSetEnabled("SSAO", %toEnable);
}

function ppOptionsEnableHDR::onAction(%this)
{
   %toEnable = PostFXManager.getEnableResultFromControl(%this);
   PostFXManager.settingsEffectSetEnabled("HDR", %toEnable);
}

function ppOptionsEnableLightRays::onAction(%this)
{
   %toEnable = PostFXManager.getEnableResultFromControl(%this);
   PostFXManager.settingsEffectSetEnabled("LightRays", %toEnable);
}

function ppOptionsEnableDOF::onAction(%this)
{ 
   %toEnable = PostFXManager.getEnableResultFromControl(%this);
   PostFXManager.settingsEffectSetEnabled("DOF", %toEnable);
}

function ppOptionsEnableSharpness::onAction(%this)
{
   %toEnable = PostFXManager.getEnableResultFromControl(%this);
   PostFXManager.settingsEffectSetEnabled("Sharp", %toEnable);
}

function ppOptionsEnableNV::onAction(%this)
{
   %toEnable = PostFXManager.getEnableResultFromControl(%this);
   PostFXManager.settingsEffectSetEnabled("NV", %toEnable);
}

 
function ppOptionsSavePreset::onClick(%this)
{
   //Stores the current settings into a preset file for loading and use later on 
}

function ppOptionsLoadPreset::onClick(%this)
{
   //Loads and applies the settings from a postfxpreset file
}


//Other controls, Quality dropdown
function ppOptionsSSAOQuality::onSelect( %this, %id, %text )
{
   if(%id > -1 && %id < 3)
   {
      $SSAOPostFx::quality = %id;
   }
}

//SSAO Slider controls
//General Tab
function ppOptionsSSAOOverallStrength::onMouseDragged(%this)
{
   $SSAOPostFx::overallStrength = %this.value;
   %this.ToolTip = "Value : " @ %this.value;
}

function ppOptionsSSAOBlurDepth::onMouseDragged(%this)
{
   $SSAOPostFx::blurDepthTol = %this.value;
   %this.ToolTip = "Value : " @ %this.value;
}

function ppOptionsSSAOBlurNormal::onMouseDragged(%this)
{
   $SSAOPostFx::blurNormalTol = %this.value;
   %this.ToolTip = "Value : " @ %this.value;
}

//Near Tab
function ppOptionsSSAONearRadius::onMouseDragged(%this)
{
   $SSAOPostFx::sRadius = %this.value;
   %this.ToolTip = "Value : " @ %this.value;
}

function ppOptionsSSAONearStrength::onMouseDragged(%this)
{
   $SSAOPostFx::sStrength = %this.value;
   %this.ToolTip = "Value : " @ %this.value;
}

function ppOptionsSSAONearDepthMin::onMouseDragged(%this)
{
   $SSAOPostFx::sDepthMin = %this.value;
   %this.ToolTip = "Value : " @ %this.value;
}

function ppOptionsSSAONearDepthMax::onMouseDragged(%this)
{
   $SSAOPostFx::sDepthMax = %this.value;
   %this.ToolTip = "Value : " @ %this.value;   
}

function ppOptionsSSAONearToleranceNormal::onMouseDragged(%this)
{
   $SSAOPostFx::sNormalTol = %this.value;
   %this.ToolTip = "Value : " @ %this.value;
}

function ppOptionsSSAONearTolerancePower::onMouseDragged(%this)
{
   $SSAOPostFx::sNormalPow = %this.value;
   %this.ToolTip = "Value : " @ %this.value;
}

//Far Tab
function ppOptionsSSAOFarRadius::onMouseDragged(%this)
{
   $SSAOPostFx::lRadius = %this.value;
   %this.ToolTip = "Value : " @ %this.value;
}
function ppOptionsSSAOFarStrength::onMouseDragged(%this)
{
   $SSAOPostFx::lStrength = %this.value;
   %this.ToolTip = "Value : " @ %this.value;
}
function ppOptionsSSAOFarDepthMin::onMouseDragged(%this)
{
   $SSAOPostFx::lDepthMin = %this.value;
   %this.ToolTip = "Value : " @ %this.value;
}
function ppOptionsSSAOFarDepthMax::onMouseDragged(%this)
{
   $SSAOPostFx::lDepthMax = %this.value;
   %this.ToolTip = "Value : " @ %this.value;
}
function ppOptionsSSAOFarToleranceNormal::onMouseDragged(%this)
{
   $SSAOPostFx::lNormalTol = %this.value;
   %this.ToolTip = "Value : " @ %this.value;
}
function ppOptionsSSAOFarTolerancePower::onMouseDragged(%this)
{
   $SSAOPostFx::lNormalPow = %this.value;
   %this.ToolTip = "Value : " @ %this.value;
}

//HDR Slider Controls
//Brighness tab

function ppOptionsHDRToneMappingAmount::onMouseDragged(%this)
{

   $HDRPostFX::enableToneMapping = %this.value;
   %this.ToolTip = "value : " @ %this.value;
}

function ppOptionsHDRKeyValue::onMouseDragged(%this)
{
   $HDRPostFX::keyValue = %this.value;
   %this.ToolTip = "Value : " @ %this.value;
}

function ppOptionsHDRMinLuminance::onMouseDragged(%this)
{
   $HDRPostFX::minLuminace = %this.value;
   %this.ToolTip = "Value : " @ %this.value;
}

function ppOptionsHDRWhiteCutoff::onMouseDragged(%this)
{
   $HDRPostFX::whiteCutoff = %this.value;
   %this.ToolTip = "Value : " @ %this.value;
}

function ppOptionsHDRBrightnessAdaptRate::onMouseDragged(%this)
{
   $HDRPostFX::adaptRate = %this.value;
   %this.ToolTip = "Value : " @ %this.value;
}

//Blur tab
function ppOptionsHDRBloomBlurBrightPassThreshold::onMouseDragged(%this)
{
   $HDRPostFX::brightPassThreshold = %this.value;
   %this.ToolTip = "Value : " @ %this.value;
}

function ppOptionsHDRBloomBlurMultiplier::onMouseDragged(%this)
{
   $HDRPostFX::gaussMultiplier = %this.value;
   %this.ToolTip = "Value : " @ %this.value;
}

function ppOptionsHDRBloomBlurMean::onMouseDragged(%this)
{
   $HDRPostFX::gaussMean = %this.value;
   %this.ToolTip = "Value : " @ %this.value;
}

function ppOptionsHDRBloomBlurStdDev::onMouseDragged(%this)
{
   $HDRPostFX::gaussStdDev = %this.value;
   %this.ToolTip = "Value : " @ %this.value;
}

function ppOptionsHDRBloom::onAction(%this)
{
   $HDRPostFX::enableBloom =  %this.getValue();
}

function ppOptionsHDRToneMapping::onAction(%this)
{
   //$HDRPostFX::enableToneMapping =  %this.getValue();
}

function ppOptionsHDREffectsBlueShift::onAction(%this)
{
   $HDRPostFX::enableBlueShift = %this.getValue();
}


//Controls for color range in blue Shift dialog

function ppOptionsHDREffectsBlueShiftColorBlend::onAction(%this)
{
   $HDRPostFX::blueShiftColor = %this.PickColor;
   %this.ToolTip = "Color Values : " @ %this.PickColor;
}

function ppOptionsHDREffectsBlueShiftColorBaseColor::onAction(%this)
{
	//This one feeds the one above
   	ppOptionsHDREffectsBlueShiftColorBlend.baseColor = %this.PickColor;
	%this.ToolTip = "Color Values : " @ %this.PickColor;
}


//Light rays Slider Controls
function ppOptionsLightRaysBrightScalar::onMouseDragged(%this)
{
   $LightRayPostFX::brightScalar = %this.value;
   %this.ToolTip = "Value : " @ %this.value;
}

function ppOptionsUpdateDOFSettings()
{
   DOFPostEffect.setFocusParams( $DOFPostFx::BlurMin, $DOFPostFx::BlurMax, $DOFPostFx::FocusRangeMin, $DOFPostFx::FocusRangeMax, -($DOFPostFx::BlurCurveNear), $DOFPostFx::BlurCurveFar );
}

//DOF General Tab
//DOF Toggles
function ppOptionsDOFEnableDOF::onAction(%this)
{
   $PostFXManager::PostFX::EnableDOF = %this.getValue();
   if(%this.getValue())
   {
      DOFPostEffect.enable();
   }
   else
   {
      DOFPostEffect.disable();
   }
}


function ppOptionsDOFEnableAutoFocus::onAction(%this)
{
   $DOFPostFx::EnableAutoFocus = %this.getValue();
   DOFPostEffect.setAutoFocus( %this.getValue() );
}

//DOF AutoFocus Slider controls
function ppOptionsDOFFarBlurMinSlider::onMouseDragged(%this)
{
   $DOFPostFx::BlurMin = %this.value;
   ppOptionsUpdateDOFSettings();
}

function ppOptionsDOFFarBlurMaxSlider::onMouseDragged(%this)
{
   $DOFPostFx::BlurMax = %this.value;
   ppOptionsUpdateDOFSettings();
}

function ppOptionsDOFFocusRangeMinSlider::onMouseDragged(%this)
{
   $DOFPostFx::FocusRangeMin = %this.value;
   ppOptionsUpdateDOFSettings();   
}

function ppOptionsDOFFocusRangeMaxSlider::onMouseDragged(%this)
{
   $DOFPostFx::FocusRangeMax = %this.value;
   ppOptionsUpdateDOFSettings();   
}

function ppOptionsDOFBlurCurveNearSlider::onMouseDragged(%this)
{
   $DOFPostFx::BlurCurveNear = %this.value;
   ppOptionsUpdateDOFSettings();
}

function ppOptionsDOFBlurCurveFarSlider::onMouseDragged(%this)
{
   $DOFPostFx::BlurCurveFar = %this.value;
   ppOptionsUpdateDOFSettings();   
}

function ppOptionsSharpenRange::onMouseDragged(%this)
{
   $SharpPostFx::sharpRange = %this.value;
    %this.ToolTip = "Value : " @ %this.value;
}

function ppOptionsSharpenWidth::onMouseDragged(%this)
{
   $SharpPostFx::sharpWidth = %this.value;  
    %this.ToolTip = "Value : " @ %this.value;
}

function ppOptionsSharpenStrength::onMouseDragged(%this)
{
   $SharpPostFx::sharpPower = %this.value;
    %this.ToolTip = "Value : " @ %this.value;     
}

//NightVision brightness
function ppOptionsNVBright::onMouseDragged(%this)
{
   $NVPostFx::brightThreshold = %this.value;
    %this.ToolTip = "Value : " @ %this.value;
}

function ppOptionsNVLowMul::onMouseDragged(%this)
{
   $NVPostFx::lowMultiplier = %this.value;
    %this.ToolTip = "Value : " @ %this.value;
}

function ppOptionsNVHighMul::onMouseDragged(%this)
{
   $NVPostFx::highMultiplier = %this.value;
    %this.ToolTip = "Value : " @ %this.value;
}

//NightVision distortion
function ppOptionsNVDistMul::onMouseDragged(%this)
{
   $NVPostFx::DistMul = %this.value;
    %this.ToolTip = "Value : " @ %this.value;
}

function ppOptionsNVDistFreq::onMouseDragged(%this)
{
   $NVPostFx::DistFreq = %this.value;
    %this.ToolTip = "Value : " @ %this.value;
}

function ppOptionsNVDistRoll::onMouseDragged(%this)
{
    $NVPostFx::DistRoll = %this.value;
    %this.ToolTip = "Value : " @ %this.value;
}



//

function ppOptionsEnableHDRDebug::onAction(%this)
{
   if ( %this.getValue() )
      LuminanceVisPostFX.enable();
   else
      LuminanceVisPostFX.disable();   
}