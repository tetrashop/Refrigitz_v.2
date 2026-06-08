from flask import Flask, request, jsonify

app = Flask(__name__)

# اضافه کردن مسیر ریشه برای جلوگیری از خطای 404
@app.route('/')
def home():
    return "Refrigitz API is running. Use POST /api/cooling/optimize or GET /health"

@app.route('/api/cooling/optimize', methods=['POST'])
def optimize_cooling():
    try:
        data = request.get_json()
        if not data:
            return jsonify({"error": "بدنه درخواست خالی است"}), 400

        current_temp = data.get('currentTemperature')
        target_temp = data.get('targetTemperature')
        humidity = data.get('humidity')

        if current_temp is None or target_temp is None or humidity is None:
            return jsonify({"error": "فیلدهای مورد نیاز: currentTemperature, targetTemperature, humidity"}), 400

        if not isinstance(current_temp, (int, float)) or not isinstance(target_temp, (int, float)) or not isinstance(humidity, int):
            return jsonify({"error": "نوع داده نامعتبر"}), 400

        if current_temp < -50 or current_temp > 80:
            return jsonify({"error": "دمای فعلی باید بین -50 و 80 درجه باشد"}), 400
        if humidity < 0 or humidity > 100:
            return jsonify({"error": "رطوبت باید بین 0 و 100 درصد باشد"}), 400

        delta = current_temp - target_temp
        fan_speed = delta * 50 + (humidity / 100.0) * 20
        fan_speed = max(0, min(100, fan_speed))
        fan_speed = round(fan_speed, 2)

        return jsonify({
            "success": True,
            "suggestedFanSpeed": fan_speed,
            "message": "عملیات موفق"
        })

    except Exception as e:
        return jsonify({"success": False, "message": f"خطای داخلی: {str(e)}"}), 500

@app.route('/health', methods=['GET'])
def health():
    return jsonify({"status": "healthy"})

if __name__ == '__main__':
    app.run(host='0.0.0.0', port=8000, debug=False)
