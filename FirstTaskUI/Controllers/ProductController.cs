using FirstTaskUI.Dtos.ProductDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace FirstTaskUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
        public async Task<IActionResult> Index(ResultProductDto resultProductDto)
        {
            try
            {
                var client = _httpClientFactory.CreateClient();
                var responseMessage = await client.GetAsync("https://localhost:7061/api/Product");
                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsonData = await responseMessage.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
                    return View(values);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, $"API call failed: {responseMessage.StatusCode}");
                    return View();
                }
            }
            catch (HttpRequestException ex)
            {
                ModelState.AddModelError(string.Empty, "API cannot be reached " + ex.Message);
                return View();
            }
            catch (JsonException ex)
            {
                ModelState.AddModelError(string.Empty, "An error occurred while processing data: " + ex.Message);
                return View();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An unexpected error occurred: " + ex.Message);
                return View();
            }
        }
        [HttpGet]
        public async Task<IActionResult> ProductDetails(int id)
        {
            try
            {
                var client = _httpClientFactory.CreateClient();
                var responseMessage = await client.GetAsync("https://localhost:7061/api/Product/" + id);
                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsonData = await responseMessage.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<GetProductDto>(jsonData);
                    return View(values);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, $"API call failed: {responseMessage.StatusCode}");
                    return View();
                }

            }
            catch (HttpRequestException ex)
            {
                ModelState.AddModelError(string.Empty, "API cannot be reached " + ex.Message);
                return View();
            }
            catch (JsonException ex)
            {
                ModelState.AddModelError(string.Empty, "An error occurred while processing data: " + ex.Message);
                return View();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An unexpected error occurred: " + ex.Message);
                return View();
            }
        }
        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            try
            {
                createProductDto.Status = true;
                var client = _httpClientFactory.CreateClient();
                var jsonData = JsonConvert.SerializeObject(createProductDto);
                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var responseMessage = await client.PostAsync("https://localhost:7061/api/Product", content);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, $"API call failed: {responseMessage.StatusCode}");
                    return View();
                }
            }
            catch (HttpRequestException ex)
            {
                ModelState.AddModelError(string.Empty, "API cannot be reached " + ex.Message);
                return View();
            }
            catch (JsonException ex)
            {
                ModelState.AddModelError(string.Empty, "An error occurred while processing data: " + ex.Message);
                return View();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An unexpected error occurred: " + ex.Message);
                return View();
            }
        }
        [HttpGet]
        public async Task<IActionResult> UpdateProduct(int id)
        {
            try
            {
                var client = _httpClientFactory.CreateClient();
                var responseMessage = await client.GetAsync("https://localhost:7061/api/Product/" + id);
                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsonData = await responseMessage.Content.ReadAsStringAsync();
                    var value = JsonConvert.DeserializeObject<UpdateProductDto>(jsonData);
                    return View(value);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, $"API call failed: {responseMessage.StatusCode}");
                    return View();
                }
            }
            catch (HttpRequestException ex)
            {
                ModelState.AddModelError(string.Empty, "API cannot be reached " + ex.Message);
                return View();
            }
            catch (JsonException ex)
            {
                ModelState.AddModelError(string.Empty, "An error occurred while processing data: " + ex.Message);
                return View();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An unexpected error occurred: " + ex.Message);
                return View();
            }
        }
        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            try
            {
                var client = _httpClientFactory.CreateClient();
                var jsonData = JsonConvert.SerializeObject(updateProductDto);
                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var responseMessage = await client.PutAsync("https://localhost:7061/api/Product", content);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, $"API call failed: {responseMessage.StatusCode}");
                    return View();
                }
            }
            catch (HttpRequestException ex)
            {
                ModelState.AddModelError(string.Empty, "API cannot be reached " + ex.Message);
                return View();
            }
            catch (JsonException ex)
            {
                ModelState.AddModelError(string.Empty, "An error occurred while processing data: " + ex.Message);
                return View();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An unexpected error occurred: " + ex.Message);
                return View();
            }
        }
        public async Task<IActionResult> DeleteProduct(int id)
        {
            try
            {
                var client = _httpClientFactory.CreateClient();
                var responseMessage = await client.DeleteAsync("https://localhost:7061/api/Product/" + id);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, $"API call failed: {responseMessage.StatusCode}");
                    return View();
                }
            }
            catch (HttpRequestException ex)
            {
                ModelState.AddModelError(string.Empty, "API cannot be reached " + ex.Message);
                return View();
            }
            catch (JsonException ex)
            {
                ModelState.AddModelError(string.Empty, "An error occurred while processing data: " + ex.Message);
                return View();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An unexpected error occurred: " + ex.Message);
                return View();
            }
        }
    }
}
