namespace CatalogApplication.Seeding.SeedData;

internal static class ProductSeedData
{
    internal const double MaxPrice = 10000;
    internal const double MaxRating = 5;
    internal const int ImagesPerCategory = 5;
    internal const string TestImage = "/images/test.jpeg";
    internal static readonly Dictionary<string, string> ProductNamesByPrimaryCategory = new() {
        { CategorySeedData.PrimaryCategories[0], "Computer" },
        { CategorySeedData.PrimaryCategories[1], "Smartphone" },
        { CategorySeedData.PrimaryCategories[2], "Television" },
        { CategorySeedData.PrimaryCategories[3], "Camera" },
        { CategorySeedData.PrimaryCategories[4], "Headphone" },
        { CategorySeedData.PrimaryCategories[5], "Wearable" },
        { CategorySeedData.PrimaryCategories[6], "Cable" },
        { CategorySeedData.PrimaryCategories[7], "Storage Device" },
        { CategorySeedData.PrimaryCategories[8], "Appliance" },
        { CategorySeedData.PrimaryCategories[9], "Office Electronic" }
    };
    internal static readonly string[] ProductDescriptions = [
        "This product is crafted with the utmost care to ensure the highest quality. It is designed to meet the needs of customers who value durability and performance. Whether you are using it daily or occasionally, this product will provide reliable service. Its elegant design complements any setting, making it both functional and stylish. The materials used are of premium quality, ensuring long-lasting use. Easy to maintain and user-friendly, it is a perfect addition to your collection. Experience the perfect blend of innovation and tradition with this exceptional product.",
        "Introducing a product that combines modern technology with user-centric design. It offers a seamless experience, making it an essential tool for anyone. The product is engineered to perform under various conditions, ensuring that it meets all your needs. It is lightweight, portable, and easy to handle, making it ideal for both home and travel. With its intuitive interface, you will find it easy to use right from the start. Invest in a product that offers both practicality and efficiency, ensuring you get the best value for your money.",
        "Our product stands out due to its exceptional build quality and attention to detail. It has been meticulously tested to ensure it meets the highest standards of performance and reliability. Designed for those who demand the best, this product offers unparalleled functionality and ease of use. Its sleek and modern design will add a touch of sophistication to any environment. Whether for personal or professional use, this product is sure to exceed your expectations and provide excellent service for years to come.",
        "Experience innovation with our latest product. It is designed to simplify your life and enhance your daily routine. The product features cutting-edge technology and is made from high-quality materials, ensuring durability and longevity. Its user-friendly interface makes it accessible to everyone, regardless of technical expertise. The product is versatile and can be used in various settings, offering great flexibility. It is a smart investment that will pay off in the long run, providing you with reliable performance and satisfaction.",
        "This product is a perfect blend of form and function. Its design is both aesthetically pleasing and highly practical. Made from premium materials, it is built to last and withstand daily wear and tear. The product is easy to use, with features that make it incredibly convenient. It offers excellent value for money, providing high performance at an affordable price. Whether you are looking for something for personal use or as a gift, this product is an excellent choice that will not disappoint.",
        "Discover the superior quality and craftsmanship of this product. It is designed to deliver outstanding performance and reliability, ensuring you get the most out of your purchase. The product is versatile and can be used in a variety of situations, making it a valuable addition to your toolkit. Its sleek design and user-friendly features make it easy to use and maintain. Invest in a product that combines durability, functionality, and style, and enjoy the benefits it brings to your daily life.",
        "Our product is engineered to provide exceptional performance and durability. It is designed with the user in mind, offering a range of features that make it practical and easy to use. The high-quality materials used in its construction ensure it will stand the test of time. Its modern design makes it a stylish addition to any setting. Whether you need it for professional or personal use, this product is a reliable and efficient choice that will meet all your needs.",
        "Introducing a product that redefines quality and reliability. It is made from the finest materials, ensuring it delivers top-notch performance every time. The product is easy to use and maintain, with features that make it incredibly convenient. Its design is both modern and timeless, making it a great addition to any collection. Whether you are using it at home or on the go, this product is designed to provide the best possible experience. Invest in a product that offers unbeatable value and performance.",
        "This product is designed to offer the perfect balance of performance and convenience. It is made from high-quality materials, ensuring it is both durable and reliable. The product features a range of user-friendly features that make it easy to use and maintain. Its sleek and modern design makes it a stylish addition to any environment. Whether you need it for everyday use or special occasions, this product is a versatile and practical choice that will not disappoint.",
        "Our product is the result of extensive research and development. It is designed to meet the highest standards of performance and reliability, ensuring you get the best possible experience. The product is easy to use, with features that make it incredibly convenient. Its modern design and high-quality materials make it a durable and stylish choice. Whether you are using it at home or on the go, this product is designed to provide reliable performance and satisfaction.",
        "Discover the exceptional quality and performance of this product. It is designed to meet the needs of customers who demand the best. The product is made from high-quality materials, ensuring it is both durable and reliable. Its user-friendly features make it easy to use and maintain, while its sleek design makes it a stylish addition to any setting. Whether you need it for everyday use or special occasions, this product is a practical and versatile choice that will provide excellent service for years to come.",
        "This product is designed with the user in mind, offering a range of features that make it practical and easy to use. It is made from high-quality materials, ensuring it is both durable and reliable. The product is lightweight and portable, making it ideal for use at home or on the go. Its sleek and modern design makes it a stylish addition to any collection. Invest in a product that offers both functionality and convenience, and enjoy the benefits it brings to your daily life.",
        "Our product is the perfect blend of innovation and tradition. It is designed to meet the needs of modern users, offering a range of features that make it practical and easy to use. The high-quality materials used in its construction ensure it is both durable and reliable. Its sleek and stylish design makes it a great addition to any setting. Whether you need it for personal or professional use, this product is a reliable and efficient choice that will meet all your needs.",
        "Experience the perfect combination of quality and performance with our product. It is designed to provide reliable service and meet the highest standards of performance. The product is made from premium materials, ensuring it is both durable and stylish. Its user-friendly features make it easy to use and maintain, while its modern design makes it a great addition to any collection. Whether you are using it at home or on the go, this product is designed to provide the best possible experience.",
        "This product is crafted to deliver exceptional performance and reliability. It is designed with the user in mind, offering a range of features that make it practical and easy to use. The high-quality materials used in its construction ensure it will stand the test of time. Its sleek and modern design makes it a stylish addition to any setting. Whether you need it for professional or personal use, this product is a reliable and efficient choice that will meet all your needs."
    ];
}