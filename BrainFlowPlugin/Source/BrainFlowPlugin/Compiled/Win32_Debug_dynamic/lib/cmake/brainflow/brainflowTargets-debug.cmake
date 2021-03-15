#----------------------------------------------------------------
# Generated CMake target import file for configuration "Debug".
#----------------------------------------------------------------

# Commands may need to know the format version.
set(CMAKE_IMPORT_FILE_VERSION 1)

# Import target "brainflow::BoardController32" for configuration "Debug"
set_property(TARGET brainflow::BoardController32 APPEND PROPERTY IMPORTED_CONFIGURATIONS DEBUG)
set_target_properties(brainflow::BoardController32 PROPERTIES
  IMPORTED_IMPLIB_DEBUG "${_IMPORT_PREFIX}/lib/BoardController32.lib"
  IMPORTED_LOCATION_DEBUG "${_IMPORT_PREFIX}/lib/BoardController32.dll"
  )

list(APPEND _IMPORT_CHECK_TARGETS brainflow::BoardController32 )
list(APPEND _IMPORT_CHECK_FILES_FOR_brainflow::BoardController32 "${_IMPORT_PREFIX}/lib/BoardController32.lib" "${_IMPORT_PREFIX}/lib/BoardController32.dll" )

# Import target "brainflow::DataHandler32" for configuration "Debug"
set_property(TARGET brainflow::DataHandler32 APPEND PROPERTY IMPORTED_CONFIGURATIONS DEBUG)
set_target_properties(brainflow::DataHandler32 PROPERTIES
  IMPORTED_IMPLIB_DEBUG "${_IMPORT_PREFIX}/lib/DataHandler32.lib"
  IMPORTED_LOCATION_DEBUG "${_IMPORT_PREFIX}/lib/DataHandler32.dll"
  )

list(APPEND _IMPORT_CHECK_TARGETS brainflow::DataHandler32 )
list(APPEND _IMPORT_CHECK_FILES_FOR_brainflow::DataHandler32 "${_IMPORT_PREFIX}/lib/DataHandler32.lib" "${_IMPORT_PREFIX}/lib/DataHandler32.dll" )

# Import target "brainflow::DSPFilters" for configuration "Debug"
set_property(TARGET brainflow::DSPFilters APPEND PROPERTY IMPORTED_CONFIGURATIONS DEBUG)
set_target_properties(brainflow::DSPFilters PROPERTIES
  IMPORTED_LINK_INTERFACE_LANGUAGES_DEBUG "CXX"
  IMPORTED_LOCATION_DEBUG "${_IMPORT_PREFIX}/lib/DSPFilters.lib"
  )

list(APPEND _IMPORT_CHECK_TARGETS brainflow::DSPFilters )
list(APPEND _IMPORT_CHECK_FILES_FOR_brainflow::DSPFilters "${_IMPORT_PREFIX}/lib/DSPFilters.lib" )

# Import target "brainflow::WaveLib" for configuration "Debug"
set_property(TARGET brainflow::WaveLib APPEND PROPERTY IMPORTED_CONFIGURATIONS DEBUG)
set_target_properties(brainflow::WaveLib PROPERTIES
  IMPORTED_LINK_INTERFACE_LANGUAGES_DEBUG "CXX"
  IMPORTED_LOCATION_DEBUG "${_IMPORT_PREFIX}/lib/WaveLib.lib"
  )

list(APPEND _IMPORT_CHECK_TARGETS brainflow::WaveLib )
list(APPEND _IMPORT_CHECK_FILES_FOR_brainflow::WaveLib "${_IMPORT_PREFIX}/lib/WaveLib.lib" )

# Import target "brainflow::GanglionLib32" for configuration "Debug"
set_property(TARGET brainflow::GanglionLib32 APPEND PROPERTY IMPORTED_CONFIGURATIONS DEBUG)
set_target_properties(brainflow::GanglionLib32 PROPERTIES
  IMPORTED_IMPLIB_DEBUG "${_IMPORT_PREFIX}/lib/GanglionLib32.lib"
  IMPORTED_LOCATION_DEBUG "${_IMPORT_PREFIX}/lib/GanglionLib32.dll"
  )

list(APPEND _IMPORT_CHECK_TARGETS brainflow::GanglionLib32 )
list(APPEND _IMPORT_CHECK_FILES_FOR_brainflow::GanglionLib32 "${_IMPORT_PREFIX}/lib/GanglionLib32.lib" "${_IMPORT_PREFIX}/lib/GanglionLib32.dll" )

# Import target "brainflow::MLModule32" for configuration "Debug"
set_property(TARGET brainflow::MLModule32 APPEND PROPERTY IMPORTED_CONFIGURATIONS DEBUG)
set_target_properties(brainflow::MLModule32 PROPERTIES
  IMPORTED_IMPLIB_DEBUG "${_IMPORT_PREFIX}/lib/MLModule32.lib"
  IMPORTED_LOCATION_DEBUG "${_IMPORT_PREFIX}/lib/MLModule32.dll"
  )

list(APPEND _IMPORT_CHECK_TARGETS brainflow::MLModule32 )
list(APPEND _IMPORT_CHECK_FILES_FOR_brainflow::MLModule32 "${_IMPORT_PREFIX}/lib/MLModule32.lib" "${_IMPORT_PREFIX}/lib/MLModule32.dll" )

# Import target "brainflow::Brainflow32" for configuration "Debug"
set_property(TARGET brainflow::Brainflow32 APPEND PROPERTY IMPORTED_CONFIGURATIONS DEBUG)
set_target_properties(brainflow::Brainflow32 PROPERTIES
  IMPORTED_LINK_INTERFACE_LANGUAGES_DEBUG "CXX"
  IMPORTED_LOCATION_DEBUG "${_IMPORT_PREFIX}/lib/Brainflow32.lib"
  )

list(APPEND _IMPORT_CHECK_TARGETS brainflow::Brainflow32 )
list(APPEND _IMPORT_CHECK_FILES_FOR_brainflow::Brainflow32 "${_IMPORT_PREFIX}/lib/Brainflow32.lib" )

# Commands beyond this point should not need to know the version.
set(CMAKE_IMPORT_FILE_VERSION)
