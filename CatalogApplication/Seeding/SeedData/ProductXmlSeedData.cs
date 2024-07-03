namespace CatalogApplication.Seeding.SeedData;

internal static class ProductXmlSeedData
{
    internal static readonly Dictionary<string, Dictionary<string, string[]>> ProductSpecsByCategory = new() {
        // Computers & Laptops
        {
            CategorySeedData.PrimaryCategories[0], new Dictionary<string, string[]> {
                { "Processor Type", ["Intel-Core-i9", "Intel-Core-i7", "Intel-Core-i5", "Intel-Core-i3", "AMD-Ryzen-9", "AMD-Ryzen-7", "AMD-Ryzen-5", "Apple-M1", "Qualcomm-Snapdragon"] },
                { "RAM Capacity", ["2GB", "4GB", "8GB", "16GB", "32GB", "64GB", "128GB", "256GB", "512GB", "1TB", "2TB", "2TB+"] },
                { "Storage Capacity", ["128GB", "256GB", "512GB", "1TB", "2TB", "4TB", "8TB", "8TB+"] },
                { "Screen Size", ["11-inches", "13-inches", "15-inches", "17-inches", "20-inches", "20-inches-plus"] },
                { "Resolution", ["HD-720p", "Full-HD-1080p", "Quad-HD-1440p", "4K-Ultra-HD-2160p", "5K", "8K"] },
                { "Graphics Card", ["NVIDIA-GeForce-RTX", "NVIDIA-GeForce-GTX", "AMD-Radeon-RX", "Intel-Iris-Xe", "Integrated-Graphics"] },
                { "Operating System", ["Windows-10", "Windows-11", "macOS", "iOS", "iPadOS", "Android", "Chrome-OS", "Linux"] },
                { "Battery Life", ["4-hour-battery", "8-hour-battery", "12-hour-battery", "16-hour-battery", "16+-hour-battery"] },
                { "Weight", ["1-kg", "2-kg", "3-kg", "4-kg", "4+-kg"] },
                { "Dimensions", ["Compact", "Standard", "Large"] },
                { "Ports", ["USB-Type-A", "USB-Type-C", "HDMI", "Thunderbolt", "Ethernet", "Audio-Jack", "SD-Card"] },
                { "Touchscreen", ["Touchscreen" ] },
                { "Keyboard Type", ["Mechanical", "Membrane", "Scissor"] },
                { "Mouse Type", ["Wired", "Wireless", "Bluetooth", "Gaming"] },
                { "Webcam Resolution", ["720p", "1080p", "4K"] },
                { "Refresh Rate", ["60Hz", "75Hz", "120Hz", "144Hz", "240Hz"] },
                { "Connectivity", ["Wi-Fi", "Bluetooth", "Ethernet", "NFC", "5G", "4G-LTE"] },
                { "Brand", ["Apple", "Dell", "HP", "Lenovo", "Asus", "Acer", "Microsoft", "Samsung", "Sony", "LG"] },
                { "Color", ["Black", "White", "Silver", "Gray", "Blue", "Red", "Green", "Gold", "Rose-Gold"] },
                { "Material", ["Aluminum", "Plastic", "Carbon-Fiber", "Glass", "Stainless-Steel"] },
                { "Warranty Period", ["1-year-warranty", "2-years-warranty", "3-years-warranty", "5-years-warranty", "Lifetime-warranty"] },
                { "Laptop Type", ["Ultrabook", "Gaming-Laptop", "2-in-1-Convertible", "Chromebook", "Workstation"] },
                { "Touchpad Type", ["Precision-Touchpad", "Standard-Touchpad", "Button-less-Touchpad"] },
                { "Convertible", ["Convertible"] },
                { "Fingerprint Scanner", ["Fingerprint-Scanner"] },
                { "Form Factor", ["ATX", "Micro-ATX", "Mini-ITX", "Extended-ATX"] },
                { "CPU Cooling", ["Air-Cooling", "Liquid-Cooling"] },
                { "Power Supply", ["ATX", "SFX", "TFX"] },
                { "Expansion Slots", ["PCIe-x16", "PCIe-x8", "PCIe-x4", "PCIe-x1"] },
                { "Display Technology", ["LCD", "LED", "OLED", "QLED", "IPS", "TN", "VA"] },
                { "Storage Type", ["HDD", "SSD", "NVMe-SSD", "Hybrid-Drive"] },
                { "Battery Capacity", ["3000mAh", "4000mAh", "5000mAh", "6000mAh", "7000mAh", "8000mAh"] },
                { "Stylus Support", ["Stylus Support"] },
                { "Panel Type", ["IPS", "TN", "VA", "OLED"] },
                { "Response Time", ["1ms", "2ms", "4ms", "5ms"] },
                { "Aspect Ratio", ["16:9", "16:10", "21:9", "4:3"] },
                { "Curved", ["Curved Screen"] },
                { "Compatibility", ["Windows", "macOS", "Linux", "Android", "iOS"] },
                { "Interface", ["USB", "Thunderbolt", "PCIe", "SATA"] },
                { "Cable Length", ["1-foot", "3-feet", "6-feet", "10-feet", "15-feet"] },
                { "Processor Speed", ["2-GHz", "3-GHz", "4-GHz", "5-GHz"] },
                { "VR Ready", ["VR Ready"] },
                { "Overclocking Support", ["Overclocking-Support"] },
                { "Console Type", ["PlayStation", "Xbox", "Nintendo-Switch"] },
                { "Controller Type", ["Standard-Controller", "Wireless-Controller", "Gaming-Mouse-and-Keyboard"] },
                { "Genre", ["Action", "Adventure", "RPG", "FPS", "Sports", "Strategy", "Simulation"] },
                { "Platform", ["PC", "PlayStation", "Xbox", "Nintendo-Switch", "Mobile"] },
                { "ESRB Rating", ["Everyone-(E)", "Everyone-10+-(E10+)", "Teen-(T)", "Mature-(M)", "Adults-Only-(AO)", "Rating-Pending-(RP)"] },
                { "Multiplayer Support", ["Local", "Online", "LAN", "Split-Screen"] },
                { "Peripheral Type", ["Keyboard", "Mouse", "Gamepad", "Joystick", "Headset"] },
                { "Wireless Technology", ["Bluetooth", "Wi-Fi", "RF"] }
            }
        },
        // Smartphones & Tablets
        {
            CategorySeedData.PrimaryCategories[1], new Dictionary<string, string[]> {
                { "Processor Type", ["Snapdragon-888", "Snapdragon-870", "Exynos-2100", "Apple-A14-Bionic", "Apple-A15-Bionic", "Kirin-9000"] },
                { "RAM Capacity", ["2GB", "4GB", "6GB", "8GB", "12GB", "16GB", "16GB+"] },
                { "Storage Capacity", ["32GB", "64GB", "128GB", "256GB", "512GB", "1TB", "1TB+"] },
                { "Screen Size", ["5-inches", "6-inches", "7-inches", "8-inches", "8-inches+"] },
                { "Resolution", ["HD-(720p)", "Full-HD-(1080p)", "Quad-HD-(1440p)", "4K-Ultra-HD-(2160p)"] },
                { "Camera Resolution", ["8MP", "12MP", "16MP", "20MP", "24MP", "32MP", "64MP"] },
                { "Battery Capacity", ["1000mAh", "2000mAh", "3000mAh", "4000mAh", "5000mAh", "6000mAh", "6000mAh+"] },
                { "Operating System", ["Android", "iOS", "iPadOS"] },
                { "Weight", ["Less-than-100g", "100-200g", "200-300g", "300-400g", "400g+"] },
                { "Dimensions", ["Compact", "Standard", "Large"] },
                { "Connectivity", ["5G", "4G-LTE", "Wi-Fi", "Bluetooth", "NFC"] },
                { "Color", ["Black", "White", "Silver", "Gold", "Blue", "Red", "Green"] },
                { "Material", ["Plastic", "Glass", "Metal", "Ceramic"] },
                { "Water Resistance", ["IP67", "IP68", "Splash-resistant", "Waterproof"] },
                { "Wireless Charging", ["Wireless-Charging"] },
                { "Fast Charging", ["Fast-Charging"] },
                { "Biometric Authentication", ["Face-Unlock", "Fingerprint-Scanner"] },
                { "Face Unlock", ["Face-Unlock"] },
                { "Fingerprint Scanner", ["In-display", "Rear-mounted", "Side-mounted"] },
                { "Sensors", ["Accelerometer", "Gyroscope", "Proximity", "Compass", "Barometer", "Heart-Rate"] },
                { "SIM Type", ["Nano-SIM", "Micro-SIM", "eSIM", "Dual-SIM", "Single-SIM"] },
                { "Expandable Storage", ["MicroSD", "Nano-Memory-(NM)"] },
                { "Display Technology", ["AMOLED", "LCD", "IPS-LCD", "OLED"] },
                { "Touchscreen Type", ["Capacitive", "Resistive"] },
                { "Stylus Support", ["Stylus-Support"] },
                { "Smartwatch OS", ["WatchOS", "Wear-OS", "Tizen-OS"] },
                { "Heart Rate Monitor", ["Heart-Rate-Monitor"] },
                { "Sleep Tracking", ["Sleep-Tracking"] },
                { "Fitness Tracking", ["Fitness-Tracking"] },
                { "Mobile Accessory Type", ["Case", "Screen-Protector", "Charger", "Cable", "Mount"] },
                { "Compatibility", ["iOS", "Android", "Universal"] },
                { "Charging Port", ["USB-Type-C", "Lightning", "Micro-USB"] },
                { "Cable Length", ["1-foot", "3-feet", "6-feet", "10-feet"] },
                { "Mounting Type", ["Handheld", "Armband", "Car-mount", "Bike-mount"] },
                { "Protective Features", ["Shockproof", "Dust-proof", "Drop-resistant", "Scratch-resistant"] }
            }
        },
        // TVs & Home Entertainment
        {
            CategorySeedData.PrimaryCategories[2], new Dictionary<string, string[]> {
                { "Screen Size", ["32-inches", "40-inches", "50-inches", "55-inches", "65-inches", "75-inches", "85-inches", "85-inches+"] },
                { "Resolution", ["HD-(720p)", "Full-HD-(1080p)", "4K-Ultra-HD-(2160p)", "8K-Ultra-HD-(4320p)"] },
                { "Display Technology", ["LED", "OLED", "QLED", "NanoCell", "LCD"] },
                { "HDR Support", ["HDR10", "Dolby-Vision", "HLG", "HDR10+"] },
                { "Refresh Rate", ["60Hz", "120Hz", "240Hz", "Variable-Refresh-Rate-(VRR)"] },
                { "Smart TV Features", ["Smart-Hub", "Voice-Control", "Streaming-Apps", "Screen-Mirroring"] },
                { "Audio Output", ["Stereo", "Dolby-Audio", "DTS"] },
                { "Speaker Configuration", ["2.0-Channel", "2.1-Channel", "5.1-Channel", "7.1-Channel"] },
                { "Sound Technology", ["Dolby-Atmos", "DTS:X", "Virtual-Surround"] },
                { "Connectivity", ["Wi-Fi", "Ethernet", "Bluetooth", "HDMI", "USB"] },
                { "Streaming Services", ["Netflix", "Amazon-Prime-Video", "Disney+", "Hulu", "YouTube"] },
                { "Media Compatibility", ["AVI", "MP4", "MKV", "MP3", "AAC"] },
                { "Projection Technology", ["DLP", "LCD", "LCoS"] },
                { "Brightness", ["300-nits", "500-nits", "1000-nits", "2000-nits"] },
                { "Contrast Ratio", ["1000:1", "2000:1", "5000:1", "10000:1"] },
                { "Throw Ratio", ["Short-Throw", "Normal-Throw", "Long-Throw"] },
                { "Keystone Correction", ["Manual", "Automatic", "None"] },
                { "Lamp Life", ["5000-hours", "10000-hours", "20000-hours", "50000-hours"] },
                { "Aspect Ratio", ["16:9", "16:10", "4:3", "21:9"] },
                { "Home Theater System Type", ["Soundbar", "Component-System", "Home-Theater-in-a-Box-(HTIB)"] },
                { "Number of Speakers", ["2", "3", "5", "7", "More-than-7"] },
                { "Power Output", ["100W", "200W", "500W", "1000W"] },
                { "Surround Sound Formats", ["Dolby-Digital", "DTS", "THX"] },
                { "Media Player Type", ["Streaming-Stick", "Set-Top-Box", "Blu-ray-Player", "DVD-Player"] },
                { "Supported Formats", ["AVI", "MP4", "MKV", "MP3", "AAC"] },
                { "Storage Capacity", ["8GB", "16GB", "32GB", "64GB", "128GB"] },
                { "Remote Control Type", ["Infrared-(IR)", "RF-(Radio-Frequency)", "Bluetooth"] },
                { "Mounting Options", ["Tabletop-Stand", "Wall-Mount", "Ceiling-Mount"] },
                { "Cable Length", ["1-meter", "2-meters", "3-meters", "5-meters"] },
                { "Compatibility", ["HDMI", "USB", "Bluetooth", "Wi-Fi"] }
            }
        },
        // Cameras & Photography
        {
            CategorySeedData.PrimaryCategories[3], new Dictionary<string, string[]> {
                { "Megapixels", ["10MP", "20MP", "24MP", "30MP", "40MP", "50MP", "More-than-50MP"] },
                { "Sensor Type", ["CMOS", "CCD", "BIS"] },
                { "Lens Mount", ["Canon-EF", "Nikon-F", "Sony-E", "Micro-Four-Thirds"] },
                { "Lens Type", ["Prime", "Zoom", "Wide-Angle", "Macro", "Telephoto"] },
                { "Aperture Range", ["f/1.8", "f/2.8", "f/4", "f/5.6"] },
                { "Focal Length", ["24mm", "35mm", "50mm", "85mm", "100mm", "200mm", "More-than-200mm"] },
                { "Image Stabilization", ["Image Stabilization"] },
                { "Autofocus System", ["Phase-Detection", "Contrast-Detection", "Hybrid"] },
                { "ISO Range", ["ISO-100", "ISO-200", "ISO-400", "ISO-800", "ISO-1600"] },
                { "Shutter Speed", ["1/1000-sec", "1/2000-sec", "1/4000-sec", "1/8000-sec"] },
                { "Viewfinder Type", ["Optical", "Electronic", "None"] },
                { "LCD Screen Size", ["2-inches", "3-inches", "3.2-inches", "3.5-inches"] },
                { "Video Resolution", ["HD-(720p)", "Full-HD-(1080p)", "4K-Ultra-HD-(2160p)"] },
                { "Frame Rate", ["24fps", "30fps", "60fps", "120fps"] },
                { "Recording Formats", ["JPEG", "RAW", "MP4", "AVCHD"] },
                { "Wireless Connectivity", ["Wi-Fi", "Bluetooth", "NFC"] },
                { "Waterproof", ["Waterproof"] },
                { "Shockproof", ["Shockproof"] },
                { "Freezeproof", ["Freezeproof"] },
                { "Action Camera Type", ["Helmet-Mount", "Body-Mount", "360-degree"] },
                { "Drone Type", ["Quadcopter", "Hexacopter", "Octocopter"] },
                { "Flight Time", ["10-minutes", "20-minutes", "30-minutes", "40-minutes"] },
                { "Maximum Range", ["100-meters", "500-meters", "1-kilometer", "5-kilometers"] },
                { "Camera Drone Resolution", ["1080p", "4K", "6K"] },
                { "Gimbal Stabilization", ["2-axis", "3-axis", "4-axis"] },
                { "Battery Capacity", ["1000mAh", "2000mAh", "3000mAh", "4000mAh"] },
                { "Compatible Devices", ["iOS-Devices", "Android-Devices", "Windows-PCs", "Mac-Computers"] },
                { "Storage Type", ["SD-Card", "microSD-Card", "CFexpress", "Internal-Memory"] },
                { "Tripod Mount", ["1/4-inch", "3/8-inch"] },
                { "Camera Bag Type", ["Backpack", "Shoulder-Bag", "Sling-Bag", "Hard-Case"] },
                { "Filter Size", ["52mm", "58mm", "67mm", "77mm"] },
                { "Compatibility", ["Windows", "macOS", "iOS", "Android"] }
            }
        },
        // Audio & Headphones
        {
            CategorySeedData.PrimaryCategories[4], new Dictionary<string, string[]> {
                { "Driver Type", ["Dynamic", "Planar-Magnetic", "Electrostatic"] },
                { "Sound Quality", ["Hi-Res-Audio", "Studio-Quality", "Enhanced-Bass", "Balanced-Sound"] },
                { "Frequency Response", ["20Hz-20kHz", "10Hz-40kHz"] },
                { "Impedance", ["16-ohms", "32-ohms", "64-ohms", "150-ohms"] },
                { "Sensitivity", ["90-dB", "100-dB", "110-dB", "120-dB"] },
                { "Noise Cancellation", ["Active-Noise-Cancellation-(ANC)", "Passive-Noise-Cancellation", "No-Noise-Cancellation"] },
                { "Microphone Type", ["Built-in", "Detachable-Boom", "In-Line"] },
                { "Wireless Technology", ["Bluetooth", "RF", "Infrared-(IR)"] },
                { "Bluetooth Version", ["Bluetooth-4.2", "Bluetooth-5.0", "Bluetooth-5.1", "Bluetooth-5.2"] },
                { "Battery Life", ["Up-to-10-hours", "10-20-hours", "20-30-hours", "30+-hours"] },
                { "Fit Type", ["In-Ear", "On-Ear", "Over-Ear", "Neckband"] },
                { "Earbud Type", ["True-Wireless-Earbuds", "Wireless-Earbuds-with-Neckband", "Wired-Earbuds"] },
                { "Headband Type", ["Adjustable", "Fixed"] },
                { "Speaker Configuration", ["Mono", "Stereo", "2.1-Channel", "5.1-Channel"] },
                { "Power Output", ["10W", "20W", "50W", "100W"] },
                { "Frequency Range", ["FM-(88MHz-108MHz)", "AM-(530kHz-1710kHz)"] },
                { "Connectivity", ["Bluetooth", "Wi-Fi", "Auxiliary-(AUX)", "USB"] },
                { "Audio Input", ["3.5mm-Audio-Jack", "USB", "Bluetooth"] },
                { "Supported Audio Formats", ["MP3", "AAC", "WAV", "FLAC"] },
                { "Playback Controls", ["Buttons", "Touch-Controls", "Voice-Control"] },
                { "Water Resistance", ["IPX4", "IPX5", "IPX7", "IPX8"] },
                { "Portability", ["Portable", "Desktop"] },
                { "Smart Assistant Integration", ["Amazon-Alexa", "Google-Assistant", "Apple-Siri"] },
                { "Equalizer", ["Customizable-Equalizer", "Pre-set-Equalizer-Modes", "No-Equalizer"] },
                { "Home Audio System Type", ["Soundbar", "Bookshelf-Speakers", "Floorstanding-Speakers", "Home-Theater-System"] },
                { "Channels", ["2.0-Channel", "2.1-Channel", "5.1-Channel", "7.1-Channel"] },
                { "Total Power Output", ["50W", "100W", "200W", "500W"] },
                { "MP3 Player Type", ["Portable-MP3-Player", "MP3-Player-with-Bluetooth"] },
                { "Storage Capacity", ["8GB", "16GB", "32GB", "64GB"] },
                { "Screen Size", ["1.8-inches", "2.4-inches", "3-inches"] },
                { "Audio Accessory Type", ["Headphone-Case", "Earbud-Tips", "Audio-Cable"] },
                { "Compatibility", ["Windows", "macOS", "iOS", "Android"] },
                { "Cable Length", ["1-meter", "2-meters", "3-meters", "5-meters"] },
                { "Mounting Options", ["Wall-Mount", "Desktop-Stand", "Ceiling-Mount"] }
            }
        },
        // Wearable Technology
        {
            CategorySeedData.PrimaryCategories[5], new Dictionary<string, string[]> {
                { "Display Type", ["OLED", "AMOLED", "LCD", "E-Ink"] },
                { "Display Size", ["1-inch", "1.2-inches", "1.4-inches", "1.6-inches"] },
                { "Resolution", ["320x320", "360x360", "454x454", "512x512"] },
                { "Touchscreen", ["Touchscreen"] },
                { "Fitness Tracking", ["Steps", "Distance", "Calories-Burned", "Active-Minutes"] },
                { "Heart Rate Monitor", ["Optical-Heart-Rate-Sensor", "ECG", "PPG"] },
                { "GPS", ["GPS", "GLONASS", "Galileo", "Beidou"] },
                { "Water Resistance", ["IPX7", "IPX8", "50-meters-water-resistance"] },
                { "Battery Life", ["Up-to-1-day", "1-2-days", "2-3-days", "3-5-days", "5+-days"] },
                { "Operating System", ["Wear-OS", "watchOS", "Fitbit-OS", "Tizen"] },
                { "Compatibility", ["iOS", "Android", "iOS-&-Android"] },
                { "Strap Material", ["Silicone", "Leather", "Metal", "Nylon"] },
                { "Sensors", ["Accelerometer", "Gyroscope", "Ambient-Light-Sensor", "Barometer"] },
                { "Activity Recognition", ["Walking", "Running", "Cycling", "Swimming"] },
                { "Sleep Tracking", ["Sleep-Duration", "Sleep-Stages", "Sleep-Score"] },
                { "Sports Modes", ["Running", "Cycling", "Swimming", "Yoga"] },
                { "Smartwatch OS", ["Wear-OS", "watchOS", "Fitbit-OS", "Tizen"] },
                { "Fitness Tracker Type", ["Smartwatch", "Fitness-Band", "Smart-Ring"] },
                { "Step Counting", ["Step-Counting"] },
                { "Calorie Tracking", ["Calorie-Tracking"] },
                { "Sleep Monitoring", ["Sleep-Monitoring"] },
                { "Movement Reminders", ["Movement-Reminders"] },
                { "VR Headset Type", ["Standalone", "PCVR", "Mobile-VR"] },
                { "Field of View", ["90-degrees", "100-degrees", "110-degrees", "120-degrees"] },
                { "Refresh Rate", ["60Hz", "72Hz", "90Hz", "120Hz"] },
                { "Tracking Sensors", ["Accelerometer", "Gyroscope", "Magnetometer"] },
                { "Controller Type", ["Handheld-Controller", "Hand-Tracking"] },
                { "Wearable Accessory Type", ["Charging-Cable", "Replacement-Straps", "Screen-Protectors"] },
                { "Adjustability", ["Adjustable-Strap", "Buckle-Closure", "Hook-and-loop-Closure"] },
                { "Charging Type", ["USB-Type-C", "Proprietary-Charger", "Wireless-Charging"] }
            }
        },
        // Cables & Adapters
        {
            CategorySeedData.PrimaryCategories[6], new Dictionary<string, string[]> {
                { "Connector Type", ["USB-Type-A", "USB-Type-C", "Micro-USB", "Lightning", "HDMI", "DVI", "VGA", "Ethernet"] },
                { "Cable Length", ["1-foot", "3-feet", "6-feet", "10-feet", "15-feet"] },
                { "Data Transfer Speed", ["USB-2.0-(480-Mbps)", "USB-3.0-(5-Gbps)", "USB-3.1-(10-Gbps)", "USB-3.2-(20-Gbps)"] },
                { "Charging Speed", ["Standard-Charging", "Fast-Charging", "Quick-Charging"] },
                { "Compatibility", ["PC", "Mac", "Android", "iOS"] },
                { "Durability", ["Standard", "Braided", "Reinforced"] },
                { "Shielding", ["Unshielded", "Shielded"] },
                { "Connector Material", ["Gold-plated", "Nickel-plated", "Aluminum"] },
                { "Color", ["Black", "White", "Gray", "Blue", "Red"] },
                { "Cable Type", ["Charging-Cable", "Data-Cable", "Audio-Cable", "Video-Cable"] },
                { "USB Standard", ["USB-2.0", "USB-3.0", "USB-3.1", "USB-3.2"] },
                { "Lightning Connector Type", ["Lightning-to-USB-A", "Lightning-to-USB-C"] },
                { "HDMI Version", ["HDMI-1.4", "HDMI-2.0", "HDMI-2.1"] },
                { "Resolution Support", ["1080p", "4K", "8K"] },
                { "DVI Version", ["DVI-D", "DVI-I", "DVI-A"] },
                { "Charger Type", ["Wall-Charger", "Car-Charger", "Wireless-Charger"] },
                { "Power Output", ["5W", "10W", "18W", "20W"] },
                { "Number of Ports", ["1-Port", "2-Ports", "4-Ports"] },
                { "Fast Charging Support", ["QC-2.0", "QC-3.0", "QC-4.0", "PD"] },
                { "Power Bank Capacity", ["5000mAh", "10000mAh", "20000mAh"] },
                { "Battery Type", ["Li-ion", "Li-polymer"] },
                { "Voltage", ["5V", "9V", "12V"] },
                { "Capacity", ["mAh", "mAh", "mAh"] },
                { "Recharge Cycles", ["500-cycles", "1000-cycles", "2000-cycles"] },
                { "Chemistry", ["NiMH", "NiCd", "Lead-Acid"] },
                { "Size", ["AAA", "AA", "C", "D"] }
            }
        },
        // Storage Devices
        {
            CategorySeedData.PrimaryCategories[7], new Dictionary<string, string[]> {
                { "Capacity", ["128GB", "256GB", "512GB", "1TB", "2TB", "4TB", "8TB"] },
                { "Interface", ["SATA-III", "NVMe-PCIe", "USB-3.0", "USB-3.1", "USB-C", "Thunderbolt"] },
                { "Read Speed", ["Up-to-500-MB/s", "Up-to-1000-MB/s", "Up-to-2000-MB/s"] },
                { "Write Speed", ["Up-to-300-MB/s", "Up-to-500-MB/s", "Up-to-1000-MB/s"] },
                { "Form Factor", ["2.5-inches", "M.2-2280", "M.2-2242", "mSATA", "PCIe-Card"] },
                { "Compatibility", ["PC", "Mac", "Linux", "Android"] },
                { "Encryption", ["AES-128-bit", "AES-256-bit", "Hardware-Encryption", "Software-Encryption"] },
                { "Shock Resistance", ["Up-to-1000G", "Up-to-1500G", "Up-to-2000G"] },
                { "Water Resistance", ["IPX4", "IPX7", "IPX8"] },
                { "USB Standard", ["USB-2.0", "USB-3.0", "USB-3.1", "USB-3.2"] },
                { "Connector Type", ["USB-Type-A", "USB-Type-C", "Micro-USB"] },
                { "Cache Size", ["8MB", "16MB", "32MB", "64MB"] },
                { "Rotation Speed", ["5400-RPM", "7200-RPM", "10000-RPM"] },
                { "Storage Technology", ["HDD", "SSD", "Hybrid-Drive"] },
                { "NAND Type", ["SLC", "MLC", "TLC", "QLC"] },
                { "Controller", ["Phison", "Samsung", "Silicon-Motion"] },
                { "Trim Support", ["Trim Support"] },
                { "Power Consumption", ["Idle:-1W", "Active:-5W"] },
                { "Operating Temperature", ["0°C-to-70°C", "-20°C-to-85°C"] },
                { "Dimensions", ["2.5\"-Drive:-7mm", "2.5\"-Drive:-9.5mm", "M.2-2280:-22mm-x-80mm"] },
                { "Weight", ["50g", "100g", "150g", "200g"] }
            }
        },
        // Home Appliances
        {
            CategorySeedData.PrimaryCategories[8], new Dictionary<string, string[]> {
                { "Capacity", ["5-kg", "7-kg", "10-kg", "12-kg", "15-kg"] },
                { "Load Type", ["Top-Load", "Front-Load"] },
                { "Washing Programs", ["Normal", "Quick-Wash", "Delicate", "Heavy-Duty", "Steam-Clean"] },
                { "Spin Speed", ["600-RPM", "800-RPM", "1000-RPM", "1200-RPM", "1400-RPM"] },
                { "Energy Efficiency", ["Energy-Star-Rated", "A+++", "A++", "A+", "A"] },
                { "Water Consumption", ["Low", "Medium", "High"] },
                { "Noise Level", ["Low", "Medium", "High"] },
                { "Dryer Type", ["Vented", "Condenser", "Heat-Pump"] },
                { "Drying Capacity", ["5-kg", "7-kg", "10-kg"] },
                { "Drying Programs", ["Cotton", "Synthetics", "Delicates", "Quick-Dry"] },
                { "Vacuum Type", ["Upright", "Canister", "Stick", "Robot"] },
                { "Suction Power", ["Low", "Medium", "High"] },
                { "Dust Capacity", ["0.5-L", "1-L", "2-L", "3-L"] },
                { "Filter Type", ["HEPA", "Cyclonic", "Foam"] },
                { "Carpet Cleaner Type", ["Upright", "Portable", "Carpet-Washer"] },
                { "Cleaning Width", ["25-cm", "30-cm", "35-cm", "40-cm"] },
                { "Water Tank Capacity", ["1-L", "2-L", "3-L"] },
                { "Microwave Capacity", ["20-liters", "25-liters", "30-liters"] },
                { "Power Output", ["600W", "800W", "1000W", "1200W"] },
                { "Cooking Modes", ["Microwave", "Grill", "Convection", "Combination"] },
                { "Oven Capacity", ["30-liters", "40-liters", "50-liters"] },
                { "Number of Racks", ["1-Rack", "2-Racks", "3-Racks"] },
                { "Refrigerator Capacity", ["100-liters", "200-liters", "300-liters"] },
                { "Defrost Type", ["Manual", "Frost-Free"] },
                { "Freezer Capacity", ["50-liters", "100-liters", "150-liters"] },
                { "Cooling Technology", ["Compressor", "Inverter", "Dual-Cooling"] },
                { "Dishwasher Type", ["Built-in", "Freestanding", "Compact"] },
                { "Place Settings", ["6-Place-Settings", "8-Place-Settings", "12-Place-Settings"] },
                { "Wash Programs", ["Normal", "Quick-Wash", "Heavy", "Eco"] },
                { "Color", ["White", "Black", "Stainless-Steel", "Silver"] },
                { "Material", ["Stainless-Steel", "Plastic", "Glass"] },
                { "Dimensions", ["Compact", "Standard", "Large"] },
                { "Weight", ["10-kg", "20-kg", "30-kg", "40-kg"] }
            }
        },
        // Office Electronics
        {
            CategorySeedData.PrimaryCategories[9], new Dictionary<string, string[]> {
                { "Printer Type", ["Inkjet", "Laser", "LED", "Dot-Matrix"] },
                { "Printing Technology", ["Monochrome", "Color"] },
                { "Print Speed", ["20ppm", "30ppm", "50ppm"] },
                { "Print Resolution", ["600dpi", "1200dpi", "2400dpi"] },
                { "Scanner Type", ["Flatbed", "Sheetfed", "Document Camera"] },
                { "Scan Resolution", ["600dpi", "1200dpi", "2400dpi"] },
                { "Document Feeder", ["ADF", "Manual"] },
                { "Duplex Printing", ["Duplex", "No-Duplex"] },
                { "Connectivity", ["USB", "Ethernet", "Wi-Fi", "Bluetooth"] },
                { "Projector Type", ["LCD", "DLP", "LED", "Laser"] },
                { "Projection Technology", ["Standard (4:3)", "Widescreen (16:9)"] },
                { "Brightness", ["2000 lumens", "3000 lumens", "4000 lumens"] },
                { "Resolution", ["SVGA (800x600)", "XGA (1024x768)", "Full HD (1920x1080)", "4K (3840x2160)"] },
                { "Throw Ratio", ["Short-Throw", "Standard-Throw", "Long-Throw"] },
                { "Keystone Correction", ["Manual", "Automatic", "No-Correction"] },
                { "Office Accessory Type", ["Desk-Organizer", "Monitor-Stand", "Keyboard-Tray"] },
                { "Compatibility", ["PC", "Mac", "Linux"] },
                { "Color", ["Black", "White", "Gray"] },
                { "Material", ["Plastic", "Metal", "Wood"] },
                { "Dimensions", ["Compact", "Standard", "Large"] },
                { "Calculator Type", ["Basic", "Scientific", "Graphing", "Printing"] },
                { "Power Source", ["Battery", "Solar", "Electric"] },
                { "Functions", ["Basic-Arithmetic", "Graphing", "Financial"] },
                { "Display Type", ["LCD", "LED", "Dot-Matrix"] },
                { "Shredder Type", ["Strip-Cut", "Cross-Cut", "Micro-Cut"] },
                { "Sheet Capacity", ["10-sheets", "20-sheets", "50-sheets"] },
                { "Shred Size", ["P-1", "P-2", "P-3", "P-4"] },
                { "Run Time", ["Continuous", "5-minutes", "10-minutes"] },
                { "Security Level", ["Level P-2", "Level P-3", "Level P-4"] }
            }
        }
    };
}